namespace OPC_DA_Read
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbOut = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btDisconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbMqttServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMQTT = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btConnMqtt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUseCredentials = new System.Windows.Forms.CheckBox();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.btDisConMqtt = new System.Windows.Forms.Button();
            this.gbMQTT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name :";
            // 
            // tbHost
            // 
            this.tbHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbHost.Location = new System.Drawing.Point(137, 21);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(311, 22);
            this.tbHost.TabIndex = 2;
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbServer.Location = new System.Drawing.Point(137, 55);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(311, 22);
            this.tbServer.TabIndex = 3;
            // 
            // tbTags
            // 
            this.tbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbTags.Location = new System.Drawing.Point(137, 87);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(311, 22);
            this.tbTags.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tag ";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(342, 191);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(118, 52);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbOut
            // 
            this.lbOut.FormattingEnabled = true;
            this.lbOut.ItemHeight = 16;
            this.lbOut.Location = new System.Drawing.Point(40, 318);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(1039, 340);
            this.lbOut.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.Location = new System.Drawing.Point(342, 191);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(118, 52);
            this.btDisconnect.TabIndex = 10;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Visible = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Topic";
            // 
            // tbTopic
            // 
            this.tbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbTopic.Location = new System.Drawing.Point(197, 82);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(231, 22);
            this.tbTopic.TabIndex = 15;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbPort.Location = new System.Drawing.Point(197, 50);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(231, 22);
            this.tbPort.TabIndex = 14;
            // 
            // tbMqttServer
            // 
            this.tbMqttServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbMqttServer.Location = new System.Drawing.Point(197, 18);
            this.tbMqttServer.Name = "tbMqttServer";
            this.tbMqttServer.Size = new System.Drawing.Size(231, 22);
            this.tbMqttServer.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = ":";
            // 
            // gbMQTT
            // 
            this.gbMQTT.Controls.Add(this.cbUseCredentials);
            this.gbMQTT.Controls.Add(this.label16);
            this.gbMQTT.Controls.Add(this.tbPass);
            this.gbMQTT.Controls.Add(this.label15);
            this.gbMQTT.Controls.Add(this.label14);
            this.gbMQTT.Controls.Add(this.label13);
            this.gbMQTT.Controls.Add(this.label12);
            this.gbMQTT.Controls.Add(this.btConnMqtt);
            this.gbMQTT.Controls.Add(this.label9);
            this.gbMQTT.Controls.Add(this.label8);
            this.gbMQTT.Controls.Add(this.tbUsername);
            this.gbMQTT.Controls.Add(this.label6);
            this.gbMQTT.Controls.Add(this.tbMqttServer);
            this.gbMQTT.Controls.Add(this.label4);
            this.gbMQTT.Controls.Add(this.tbPort);
            this.gbMQTT.Controls.Add(this.label5);
            this.gbMQTT.Controls.Add(this.tbTopic);
            this.gbMQTT.Controls.Add(this.btDisConMqtt);
            this.gbMQTT.Location = new System.Drawing.Point(532, 25);
            this.gbMQTT.Name = "gbMQTT";
            this.gbMQTT.Size = new System.Drawing.Size(547, 249);
            this.gbMQTT.TabIndex = 18;
            this.gbMQTT.TabStop = false;
            this.gbMQTT.Text = "MQTT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(150, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 22);
            this.label16.TabIndex = 26;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(150, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 22);
            this.label15.TabIndex = 25;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(150, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(150, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(150, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = ":";
            // 
            // btConnMqtt
            // 
            this.btConnMqtt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnMqtt.Location = new System.Drawing.Point(428, 210);
            this.btConnMqtt.Name = "btConnMqtt";
            this.btConnMqtt.Size = new System.Drawing.Size(113, 33);
            this.btConnMqtt.TabIndex = 22;
            this.btConnMqtt.Text = "Connect";
            this.btConnMqtt.UseVisualStyleBackColor = true;
            this.btConnMqtt.Click += new System.EventHandler(this.btConnMqtt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbUsername.Location = new System.Drawing.Point(197, 149);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(231, 22);
            this.tbUsername.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "MQTT Server ";
            // 
            // tbPass
            // 
            this.tbPass.Enabled = false;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbPass.Location = new System.Drawing.Point(197, 185);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(231, 22);
            this.tbPass.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInterval);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nudInterval);
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btDisconnect);
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.tbTags);
            this.groupBox1.Location = new System.Drawing.Point(40, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 249);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPC DA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(115, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // cbUseCredentials
            // 
            this.cbUseCredentials.AutoSize = true;
            this.cbUseCredentials.Location = new System.Drawing.Point(20, 124);
            this.cbUseCredentials.Name = "cbUseCredentials";
            this.cbUseCredentials.Size = new System.Drawing.Size(118, 20);
            this.cbUseCredentials.TabIndex = 27;
            this.cbUseCredentials.Text = "Use Credential";
            this.cbUseCredentials.UseVisualStyleBackColor = true;
            this.cbUseCredentials.CheckedChanged += new System.EventHandler(this.cbUseCredentials_CheckedChanged);
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(137, 126);
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(120, 22);
            this.nudInterval.TabIndex = 13;
            this.nudInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterval.ValueChanged += new System.EventHandler(this.nudInterval_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 22);
            this.label17.TabIndex = 14;
            this.label17.Text = "Interval";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(115, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 22);
            this.label18.TabIndex = 15;
            this.label18.Text = ":";
            // 
            // cbInterval
            // 
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "Detik",
            "Menit"});
            this.cbInterval.Location = new System.Drawing.Point(264, 123);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(121, 24);
            this.cbInterval.TabIndex = 16;
            // 
            // btDisConMqtt
            // 
            this.btDisConMqtt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisConMqtt.Location = new System.Drawing.Point(428, 210);
            this.btDisConMqtt.Name = "btDisConMqtt";
            this.btDisConMqtt.Size = new System.Drawing.Size(113, 33);
            this.btDisConMqtt.TabIndex = 28;
            this.btDisConMqtt.Text = "Disconnect";
            this.btDisConMqtt.UseVisualStyleBackColor = true;
            this.btDisConMqtt.Click += new System.EventHandler(this.btDisConMqtt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMQTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOut);
            this.Name = "Form1";
            this.Text = "OPC DA";
            this.gbMQTT.ResumeLayout(false);
            this.gbMQTT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ListBox lbOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbMqttServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMQTT;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btConnMqtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbUseCredentials;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Button btDisConMqtt;
    }
}

