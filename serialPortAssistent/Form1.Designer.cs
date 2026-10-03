namespace serialPortAssistent
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
            groupBox1 = new GroupBox();
            btnOpenAndClosePort = new Button();
            huanhang = new CheckBox();
            label6 = new Label();
            Select16HX = new RadioButton();
            SelectString = new RadioButton();
            stop = new ComboBox();
            label5 = new Label();
            check = new ComboBox();
            label4 = new Label();
            data = new ComboBox();
            label3 = new Label();
            bps = new ComboBox();
            label2 = new Label();
            serialPortNumber = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtReceiveData = new TextBox();
            groupBox3 = new GroupBox();
            btnClearData = new Button();
            btnSend = new Button();
            sendData = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpenAndClosePort);
            groupBox1.Controls.Add(huanhang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Select16HX);
            groupBox1.Controls.Add(SelectString);
            groupBox1.Controls.Add(stop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(check);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(data);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(bps);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(serialPortNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口设置";
            // 
            // btnOpenAndClosePort
            // 
            btnOpenAndClosePort.Location = new Point(71, 356);
            btnOpenAndClosePort.Name = "btnOpenAndClosePort";
            btnOpenAndClosePort.Size = new Size(104, 37);
            btnOpenAndClosePort.TabIndex = 1;
            btnOpenAndClosePort.Text = "打开串口";
            btnOpenAndClosePort.UseVisualStyleBackColor = true;
            btnOpenAndClosePort.Click += button1_Click;
            // 
            // huanhang
            // 
            huanhang.AutoSize = true;
            huanhang.Location = new Point(17, 320);
            huanhang.Name = "huanhang";
            huanhang.Size = new Size(75, 21);
            huanhang.TabIndex = 1;
            huanhang.Text = "换行显示";
            huanhang.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 255);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 4;
            label6.Text = "发送方式";
            // 
            // Select16HX
            // 
            Select16HX.AutoSize = true;
            Select16HX.Location = new Point(123, 283);
            Select16HX.Name = "Select16HX";
            Select16HX.Size = new Size(64, 21);
            Select16HX.TabIndex = 1;
            Select16HX.TabStop = true;
            Select16HX.Text = "16进制";
            Select16HX.UseVisualStyleBackColor = true;
            // 
            // SelectString
            // 
            SelectString.AutoSize = true;
            SelectString.Location = new Point(30, 283);
            SelectString.Name = "SelectString";
            SelectString.Size = new Size(62, 21);
            SelectString.TabIndex = 1;
            SelectString.TabStop = true;
            SelectString.Text = "字符串";
            SelectString.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            stop.FormattingEnabled = true;
            stop.Items.AddRange(new object[] { "1", "2" });
            stop.Location = new Point(93, 216);
            stop.Name = "stop";
            stop.Size = new Size(121, 25);
            stop.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 219);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 3;
            label5.Text = "停止位";
            // 
            // check
            // 
            check.FormattingEnabled = true;
            check.Items.AddRange(new object[] { "None", "Odd", "Even" });
            check.Location = new Point(93, 169);
            check.Name = "check";
            check.Size = new Size(121, 25);
            check.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 172);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "校验位";
            // 
            // data
            // 
            data.FormattingEnabled = true;
            data.Items.AddRange(new object[] { "7", "8" });
            data.Location = new Point(93, 120);
            data.Name = "data";
            data.Size = new Size(121, 25);
            data.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 123);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "数据位";
            // 
            // bps
            // 
            bps.FormattingEnabled = true;
            bps.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            bps.Location = new Point(93, 72);
            bps.Name = "bps";
            bps.Size = new Size(121, 25);
            bps.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "波特率";
            // 
            // serialPortNumber
            // 
            serialPortNumber.FormattingEnabled = true;
            serialPortNumber.Items.AddRange(new object[] { "com1", "com2", "com3", "com4", "com5", "com6" });
            serialPortNumber.Location = new Point(93, 25);
            serialPortNumber.Name = "serialPortNumber";
            serialPortNumber.Size = new Size(121, 25);
            serialPortNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "串口号";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtReceiveData);
            groupBox2.Location = new Point(288, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(488, 236);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据接收";
            // 
            // txtReceiveData
            // 
            txtReceiveData.Location = new Point(6, 22);
            txtReceiveData.Multiline = true;
            txtReceiveData.Name = "txtReceiveData";
            txtReceiveData.Size = new Size(476, 202);
            txtReceiveData.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClearData);
            groupBox3.Controls.Add(btnSend);
            groupBox3.Controls.Add(sendData);
            groupBox3.Location = new Point(288, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(488, 184);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "数据发送";
            // 
            // btnClearData
            // 
            btnClearData.Location = new Point(268, 141);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(104, 37);
            btnClearData.TabIndex = 6;
            btnClearData.Text = "清空接收";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(378, 141);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(104, 37);
            btnSend.TabIndex = 5;
            btnSend.Text = "发送数据";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // sendData
            // 
            sendData.Location = new Point(6, 22);
            sendData.Multiline = true;
            sendData.Name = "sendData";
            sendData.Size = new Size(476, 113);
            sendData.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox bps;
        private Label label2;
        private ComboBox serialPortNumber;
        private Label label1;
        private ComboBox stop;
        private Label label5;
        private ComboBox check;
        private Label label4;
        private ComboBox data;
        private Label label3;
        private RadioButton SelectString;
        private Button btnOpenAndClosePort;
        private CheckBox huanhang;
        private Label label6;
        private RadioButton Select16HX;
        private GroupBox groupBox2;
        private TextBox txtReceiveData;
        private GroupBox groupBox3;
        private Button btnClearData;
        private Button btnSend;
        private TextBox sendData;
    }
}
