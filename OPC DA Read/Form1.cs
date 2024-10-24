using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GodSharp.Opc.Da;
using GodSharp.Opc.Da.Options;
using System.Net.Sockets;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using MQTTnet.Exceptions;
//using MQTTnet.Client;

namespace OPC_DA_Read
{
    public partial class Form1 : Form
    {
        private IOpcDaClient _client;
        private Timer _timer;
        private IMqttClient _mqttClient;
        //private IOpcNetApiClient _client;

        public Form1()
        {
            InitializeComponent();
            _timer = new Timer(); // Inisialisasi Timer
            SetTimerInterval(); // Set interval 
            _timer.Tick += timer1_Tick;
            btDisConMqtt.Click += btDisConMqtt_Click;
            cbInterval.SelectedIndex = 0;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //IOpcNetApiClient client = null;
            try
            {
                string host = tbHost.Text;
                string progId = tbServer.Text;
                var itemNames = tbTags.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(tag => tag.Trim())
                                              .ToList();

                var groups = new List<GroupData>
                {
                    new GroupData
                    {
                        Name = "default", UpdateRate = 100, ClientHandle = 010, IsSubscribed = true,
                        Tags = itemNames.Select((itemName, index) => new Tag(itemName, index + 1)).ToList()
                    }
                };

                var server = new ServerData
                {
                    Host = host,
                    ProgId = progId,
                    Groups = groups
                };

                _client = DaClientFactory.Instance.CreateOpcNetApiClient(new DaClientOptions(
                    server,
                    OnDataChangedHandler,
                    OnShoutdownHandler,
                    OnAsyncReadCompletedHandler));

                _client.Connect();
                _timer.Start();
                SetTimerInterval();
                btConnect.Enabled = false;
                btConnect.Visible = false;
                btDisconnect.Enabled = true;
                btDisconnect.Visible = true;
                MessageBox.Show("Connected to server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            //_timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadData();
        }
        private async void ReadData()
        {
            if (_client == null || !_client.Connected)
            {
                MessageBox.Show("Client is not connected.");
                return;
            }

            try
            {
                foreach (var group in _client.Groups.Values)
                {
                    if (group.Tags.Count == 0) continue;
                    var results = group.Reads(group.Tags.Values.Select(x => x.ItemName)?.ToArray());

                    foreach (var item in results)
                    {
                        //lbOut.Items.Add($"{item.Result.ItemName} : {item.Result.Value} | {item.Result.Quality} | {item.Result.Timestamp}");
                        //{ item.Ok}|{ item.Code}
                        string message = $"{item.Result.ItemName} : {item.Result.Value} | {item.Result.Quality} | {item.Result.Timestamp}";
                        lbOut.Items.Add(message);
                        lbOut.TopIndex = lbOut.Items.Count - 1;

                        if (_mqttClient != null && _mqttClient.IsConnected)
                        {
                            // Publikasikan ke MQTT
                            var topic = tbTopic.Text; // Ambil topik dari TextBox
                            var payload = new
                            {
                                ItemName = item.Result.ItemName,
                                Value = item.Result.Value
                            };
                            string jsonPayload = JsonConvert.SerializeObject(payload);
                            var mqttMessage = new MqttApplicationMessageBuilder()
                                              .WithTopic($"{topic}") 
                                              .WithPayload(jsonPayload).WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.ExactlyOnce).Build();

                            await _mqttClient.PublishAsync(mqttMessage, System.Threading.CancellationToken.None);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during read: {ex.Message}");
            }
        }

        public void OnDataChangedHandler(DataChangedOutput output)
        {
            // Handle data changes here if needed
        }

        public void OnAsyncReadCompletedHandler(AsyncReadCompletedOutput output)
        {
            // Handle async read completion here if needed
        }

        public void OnShoutdownHandler(Server server, string reason)
        {
            MessageBox.Show($"Server shutdown: {reason}");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer?.Stop();
            _client?.Disconnect();
            _client?.Dispose();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_client != null && _client.Connected)
                {
                    _client.Disconnect(); // Putuskan sambungan dari server
                    _timer.Stop(); // Hentikan timer saat disconnect
                    btConnect.Enabled = true;
                    btConnect.Visible = true;
                    btDisconnect.Enabled = false;
                    btDisconnect.Visible=false;
                    MessageBox.Show("Disconnected from server.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during disconnection: {ex.Message}");
            }
        }

        private async void btConnMqtt_Click(object sender, EventArgs e)
        {
            var mqttFactory = new MqttFactory();
            _mqttClient = mqttFactory.CreateMqttClient();
            if (string.IsNullOrWhiteSpace(tbMqttServer.Text))
            {
                MessageBox.Show("Please enter the MQTT server address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPort.Text) || !int.TryParse(tbPort.Text, out int port))
            {
                MessageBox.Show("Please enter a valid port number.");
                return; 
            }

            var mqttOptionsBuilder = new MqttClientOptionsBuilder()
                .WithClientId("OPC_DA_Client")
                .WithTcpServer(tbMqttServer.Text, int.Parse(tbPort.Text));

            if (cbUseCredentials.Checked)
            {
                if (!string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPass.Text))
                {
                    mqttOptionsBuilder.WithCredentials(tbUsername.Text, tbPass.Text); 
                }
                else
                {
                    MessageBox.Show("Username and password must be provided when using credentials.");
                    return;
                }
            }

            var mqttOptions = mqttOptionsBuilder.Build();
            try
            {
                await _mqttClient.ConnectAsync(mqttOptions, System.Threading.CancellationToken.None);
                btDisConMqtt.Visible = true;
                btConnMqtt.Visible = false;
                MessageBox.Show("Connected to MQTT broker.");

            }
            catch (MqttCommunicationException ex)
            {
                MessageBox.Show($"Error while connecting: {ex.Message}");
            }


        }

        private void cbUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseCredentials.Checked)
            {
                tbUsername.Enabled=true;
                tbPass.Enabled=true;
                label15.Enabled = true;
                label16.Enabled = true;
                label8.Enabled = true;
                label9.Enabled=true;
            }
            else
            {
                tbUsername.Enabled = false;
                tbPass.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
            }
        }
        private void SetTimerInterval()
        {
            int multiplier = 1000;
            if (cbInterval.SelectedItem == null)
            {
                cbInterval.SelectedIndex = 0;
                //multiplier = 1000;
            }
            if (cbInterval.SelectedItem.ToString() == "Menit")
            {
                multiplier = 60000;
            }
            _timer.Interval = (int)nudInterval.Value * multiplier;
        }

        private void nudInterval_ValueChanged(object sender, EventArgs e)
        {
            SetTimerInterval();
        }

        private async void btDisConMqtt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mqttClient != null && _mqttClient.IsConnected)
                {
                    await _mqttClient.DisconnectAsync(); // Putuskan sambungan dari broker
                    MessageBox.Show("Disconnected from MQTT broker.");
                    btDisConMqtt.Visible = false;
                    btConnMqtt.Visible = true;
                }
                else
                {
                    MessageBox.Show("Client is not connected to MQTT broker.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during disconnection: {ex.Message}");
            }
        }
    }
}
