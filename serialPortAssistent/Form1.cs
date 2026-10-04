using Microsoft.Win32;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;

namespace serialPortAssistent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义变量
        private bool portIsOpen = false; // 串口是否打开
        private bool isRxShow = true; // 接收数据显示状态
        private List<byte> receiveBuffer = new List<byte>(); // 接收数据缓冲区

        private List<byte> sendBuffer = new List<byte>(); // 发送数据缓冲区
        private int receiveCount = 0; // 接收数据计数

        private int sendCount = 0; // 发送数据计数
        // 创建串口类对象
        SerialPort serialPort = new SerialPort();
        #endregion

        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            serialLoad();
        }

        private void serialLoad()
        {
            // 从设备中获取串口列表
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM");
            string[] sSubKey = keyCom.GetValueNames();
            foreach (string sValue in sSubKey)
            {
                string sName = (string)keyCom.GetValue(sValue);
                this.serialPortNumber.Items.Add(sName);
            }

            // 设置串口号 com1
            this.serialPortNumber.SelectedIndex = 0;

            // 设置波特率 9600
            this.bps.SelectedIndex = 0;
            // 设置数据位 8
            this.data.SelectedIndex = 1;
            // 设置校验位 None
            this.check.SelectedIndex = 0;
            // 设置停止位 1
            this.stop.SelectedIndex = 0;

        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenSerialPort();
        }
        /// <summary>
        /// 根据串口状态打开或关闭串口
        /// </summary>
        private void OpenSerialPort()
        {

            try
            {
                if (portIsOpen == false) // 串口未打开
                {
                    this.btnOpenAndClosePort.Text = "关闭串口";
                    serialPort.PortName = this.serialPortNumber.Text; // 设置串口号
                    serialPort.BaudRate = Convert.ToInt32(this.bps.Text); // 设置波特率
                    serialPort.DataBits = Convert.ToInt32(this.data.Text); // 设置数据位
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.check.Text); // 设置校验位
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.stop.Text); // 设置停止位

                    serialPort.Open(); // 打开串口
                    MessageBox.Show("串口打开成功！");
                    // 绑定事件用于接受数据
                    serialPort.DataReceived += Serialport_DataReceived;
                    portIsOpen = true;  // 将串口状态设为已打开

                }
                else
                {
                    this.btnOpenAndClosePort.Text = "打开串口";
                    serialPort.DataReceived -= Serialport_DataReceived; // 解绑事件
                    serialPort.Close(); // 关闭串口
                    MessageBox.Show("串口已关闭！");
                    portIsOpen = false;  // 将串口状态设为未打开
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isRxShow == false) return;
            byte[] dataTemp = new byte[serialPort.BytesToRead]; // 创建临时数组存储接收到的数据
            serialPort.Read(dataTemp, 0, dataTemp.Length); // 读取接收到的数据
            receiveBuffer.AddRange(dataTemp); // 将接收到的数据添加到缓冲区
            // 计数
            receiveCount += dataTemp.Length;

            if (this.txtReceiveData.InvokeRequired)
            {
                this.txtReceiveData.Invoke(new Action(() =>
                {
                    this.txtReceiveCount.Text = receiveCount.ToString();
                    if (!this.cb16HexReceive.Checked)
                    {
                        string str = Encoding.GetEncoding(936).GetString(dataTemp);
                        // 0x00  -> \0 是结束符不会显示，所以要将\0 进行转义替换
                        str = str.Replace("\0", "\\0");
                        this.txtReceiveData.AppendText(str); // 显示接收到的数据
                    }
                    else
                    {
                        // 将接收到的数据转换为16进制字符串
                        this.txtReceiveData.AppendText(stringTo16Hex(dataTemp)); // 显示接收到的数据
                    }

                }));
            }
            else
            {
                this.txtReceiveCount.Text = receiveCount.ToString();
                if (!this.cb16HexReceive.Checked)
                {
                    string str = Encoding.GetEncoding(936).GetString(dataTemp);
                    // 0x00  -> \0 是结束符不会显示，所以要将\0 进行转义替换
                    str = str.Replace("\0", "\\0");
                    this.txtReceiveData.AppendText(str); // 显示接收到的数据
                }
                else
                {
                    // 将接收到的数据转换为16进制字符串

                    this.txtReceiveData.AppendText(stringTo16Hex(dataTemp)); // 显示接收到的数据
                }
            }

        }

        private void send()
        {
            serialPort.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendCount += sendBuffer.Count;
            this.txtSendCount.Text = sendCount.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen && this.sendData.Text != "")
            {
                send();// 发送数据
            }
            else
            {
                MessageBox.Show("请先输入发送数据！");
            }
        }

        private void btnZt_Click(object sender, EventArgs e)
        {
            if (isRxShow == true)
            {
                isRxShow = false;
                this.btnZt.Text = "取消暂停";
            }
            else
            {
                isRxShow = true;
                this.btnZt.Text = "暂停";
            }
        }

        private void cb16HexReceive_CheckedChanged(object sender, EventArgs e)
        {
            // 将接受框的文本转换为16进制
            if (this.txtReceiveData.Text == "") return;
            if (this.cb16HexReceive.Checked)
            {
                byte[] temp = receiveBuffer.ToArray();
                // 将接收到的数据转换为16进制字符串
                this.txtReceiveData.Text = stringTo16Hex(temp);
            }
            else
            {
                this.txtReceiveData.Text = Encoding.GetEncoding(936).GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        /// <summary>
        /// 将字节数组转换为16进制字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string stringTo16Hex(byte[] data)
        {
            if (data == null || data.Length == 0) return string.Empty;
            // 将字节数组转换为16进制字节数组
            StringBuilder hexString = new StringBuilder();
            foreach (byte b in data)
            {
                hexString.AppendFormat("{0:X2} ", b);
            }

            return hexString.ToString().TrimEnd();
        }

        private void btnClearReceive_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            this.txtReceiveData.Text = "";
            receiveCount = 0;
            this.txtReceiveCount.Text = "0";
        }

        private void cbAutoClearReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cbAutoClearReceive.Checked) return;
            if (receiveCount >= 3072 && receiveCount < 4096)
            {
                MessageBox.Show("接收数据已超过3072字节，超过4096字节自动清空接收数据！");
            }
            if (receiveCount >= 4096)
            {
                receiveBuffer.Clear();
                this.txtReceiveData.Text = "";
                receiveCount = 0;
                this.txtReceiveCount.Text = "0";
            }
        }

        /// <summary>
        /// 发送数据框失去焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendData_Leave(object sender, EventArgs e)
        {
            if (this.sendData.Text == "") return;
            if (this.cb16HexSend.Checked)
            {
                if (!IsHexString(this.sendData.Text))
                {
                    MessageBox.Show("发送数据不是合法的16进制字符串，请重新输入！");
                    this.sendData.Focus();
                }
                else
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Encoding.GetEncoding(936).GetBytes(this.sendData.Text));
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding(936).GetBytes(this.sendData.Text));
            }
        }

        /// <summary>
        /// 判断字符串是否是合法的16进制字符串（允许中间带空格）
        /// </summary>
        /// <param name="hexStr">待校验字符串</param>
        /// <returns>true=合法十六进制</returns>
        public bool IsHexString(string hexStr)
        {
            if (string.IsNullOrWhiteSpace(hexStr))
                return false;

            // 移除全部空格
            string temp = hexStr.Replace(" ", "");

            // 长度必须是偶数，1个字节=2个16进制字符
            if (temp.Length % 2 != 0)
                return false;

            // 正则：只能包含 0-9 A-F a-f
            Regex regex = new Regex(@"^[0-9A-Fa-f]+$");
            return regex.IsMatch(temp);
        }

        private void sendData_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void cb16HexSend_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb16HexSend.Checked)
            {
                if (!IsHexString(this.sendData.Text))
                {
                    this.sendData.Text = stringTo16Hex(sendBuffer.ToArray());
                }
            }
            else
            {
                this.sendData.Text = Encoding.GetEncoding(936).GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            this.sendData.Text = "";
            sendCount = 0;
            this.txtSendCount.Text = "0";
        }

        private void btnClearCount_Click(object sender, EventArgs e)
        {
            this.txtSendCount.Text = "0";
            this.txtReceiveCount.Text = "0";
        }

    }
}
