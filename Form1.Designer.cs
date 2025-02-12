namespace IPSwitch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxIpConfig = new ComboBox();
            ApplyConfigBtn = new Button();
            IpSelectLabel = new Label();
            IpConfigNameLabel = new Label();
            label1 = new Label();
            ApplyConfigLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            displayConnectionName = new Label();
            displayBoxIpAddress = new Label();
            displaySubnetMask = new Label();
            displayGateway = new Label();
            displayDns1 = new Label();
            displayDns2 = new Label();
            SuspendLayout();
            // 
            // comboBoxIpConfig
            // 
            comboBoxIpConfig.FormattingEnabled = true;
            comboBoxIpConfig.Location = new Point(132, 33);
            comboBoxIpConfig.Name = "comboBoxIpConfig";
            comboBoxIpConfig.Size = new Size(189, 25);
            comboBoxIpConfig.TabIndex = 0;
            // 
            // ApplyConfigBtn
            // 
            ApplyConfigBtn.Location = new Point(132, 370);
            ApplyConfigBtn.Name = "ApplyConfigBtn";
            ApplyConfigBtn.Size = new Size(189, 23);
            ApplyConfigBtn.TabIndex = 2;
            ApplyConfigBtn.Text = "点击应用";
            ApplyConfigBtn.UseVisualStyleBackColor = true;
            ApplyConfigBtn.Click += ApplyConfigBtn_Click;
            // 
            // IpSelectLabel
            // 
            IpSelectLabel.AutoSize = true;
            IpSelectLabel.Location = new Point(38, 36);
            IpSelectLabel.Name = "IpSelectLabel";
            IpSelectLabel.Size = new Size(79, 17);
            IpSelectLabel.TabIndex = 3;
            IpSelectLabel.Text = "选择IP配置：";
            // 
            // IpConfigNameLabel
            // 
            IpConfigNameLabel.AutoSize = true;
            IpConfigNameLabel.Location = new Point(38, 88);
            IpConfigNameLabel.Name = "IpConfigNameLabel";
            IpConfigNameLabel.Size = new Size(0, 17);
            IpConfigNameLabel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 5;
            // 
            // ApplyConfigLabel
            // 
            ApplyConfigLabel.AutoSize = true;
            ApplyConfigLabel.Location = new Point(38, 373);
            ApplyConfigLabel.Name = "ApplyConfigLabel";
            ApplyConfigLabel.Size = new Size(79, 17);
            ApplyConfigLabel.TabIndex = 6;
            ApplyConfigLabel.Text = "应用IP配置：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 7;
            label2.Text = "网络连接：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 133);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 10;
            label3.Text = "IP地址：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 116);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 231);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 16;
            label5.Text = "网关地址：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 214);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 183);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 13;
            label7.Text = "子网掩码：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 166);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 324);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 22;
            label9.Text = "DNS2：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 307);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 276);
            label11.Name = "label11";
            label11.Size = new Size(53, 17);
            label11.TabIndex = 19;
            label11.Text = "DNS1：";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 259);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 18;
            // 
            // displayConnectionName
            // 
            displayConnectionName.Location = new Point(132, 86);
            displayConnectionName.Name = "displayConnectionName";
            displayConnectionName.Size = new Size(189, 23);
            displayConnectionName.TabIndex = 24;
            // 
            // displayBoxIpAddress
            // 
            displayBoxIpAddress.Location = new Point(132, 135);
            displayBoxIpAddress.Name = "displayBoxIpAddress";
            displayBoxIpAddress.Size = new Size(189, 23);
            displayBoxIpAddress.TabIndex = 25;
            // 
            // displaySubnetMask
            // 
            displaySubnetMask.Location = new Point(132, 184);
            displaySubnetMask.Name = "displaySubnetMask";
            displaySubnetMask.Size = new Size(189, 23);
            displaySubnetMask.TabIndex = 26;
            // 
            // displayGateway
            // 
            displayGateway.Location = new Point(132, 232);
            displayGateway.Name = "displayGateway";
            displayGateway.Size = new Size(189, 23);
            displayGateway.TabIndex = 27;
            // 
            // displayDns1
            // 
            displayDns1.Location = new Point(132, 276);
            displayDns1.Name = "displayDns1";
            displayDns1.Size = new Size(189, 23);
            displayDns1.TabIndex = 28;
            // 
            // displayDns2
            // 
            displayDns2.Location = new Point(132, 324);
            displayDns2.Name = "displayDns2";
            displayDns2.Size = new Size(189, 23);
            displayDns2.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 415);
            Controls.Add(displayDns2);
            Controls.Add(displayDns1);
            Controls.Add(displayGateway);
            Controls.Add(displaySubnetMask);
            Controls.Add(displayBoxIpAddress);
            Controls.Add(displayConnectionName);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(ApplyConfigLabel);
            Controls.Add(label1);
            Controls.Add(IpConfigNameLabel);
            Controls.Add(IpSelectLabel);
            Controls.Add(ApplyConfigBtn);
            Controls.Add(comboBoxIpConfig);
            Name = "Form1";
            Text = "IP配置工具";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxIpConfig;
        private Button ApplyConfigBtn;
        private Label IpSelectLabel;
        private Label IpConfigNameLabel;
        private Label label1;
        private Label ApplyConfigLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label displayConnectionName;
        private Label displayBoxIpAddress;
        private Label displaySubnetMask;
        private Label displayGateway;
        private Label displayDns1;
        private Label displayDns2;
    }
}
