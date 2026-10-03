using System.IO.Ports;
using System.Text;

namespace serialPortAssistent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义变量
        bool portIsOpen = false; // 串口是否打开
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
            // 设置默认显示
            this.SelectString.Checked = true;


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
            if (portIsOpen == false) // 串口未打开
            {
                try
                {
                    this.btnOpenAndClosePort.Text = "关闭串口";
                    serialPort.PortName = this.serialPortNumber.Text; // 设置串口号
                    serialPort.BaudRate = Convert.ToInt32(this.bps.Text); // 设置波特率
                    serialPort.DataBits = Convert.ToInt32(this.data.Text); // 设置数据位
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.check.Text); // 设置校验位
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.stop.Text); // 设置停止位

                    serialPort.Open(); // 打开串口
                    // 绑定事件用于接受数据
                    serialPort.DataReceived += Serialport_DataReceived;
                    portIsOpen = true;  // 将串口状态设为已打开
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口打开失败：" + ex.Message);
                    this.btnOpenAndClosePort.Text = "打开串口";
                    portIsOpen = false;
                }

            }
            else
            {
                try
                {
                    this.btnOpenAndClosePort.Text = "打开串口";
                    serialPort.DataReceived -= Serialport_DataReceived; // 解绑事件
                    serialPort.Close(); // 关闭串口
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口关闭失败：" + ex.Message);
                }
                portIsOpen = false;  // 将串口状态设为未打开
            }

        }

        // 串口接收数据事件方法
        private void Serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 将byte数组转换为字符串显示
            int length = serialPort.BytesToRead; // 获取接收缓冲区字节数
            if (length == 0)
            {
                return; // 如果没有数据则直接返回
            }
            Byte[] receiveBuffer = new Byte[length]; // 创建byte数组
            // 读取数据
            serialPort.Read(receiveBuffer, 0, length);
            string receiveString = "";
            // 判断数据转换成字符还是16进制
            if (this.SelectString.Checked)
            {
                // 将 Byte数组转换为字符串
                receiveString = Encoding.Default.GetString(receiveBuffer);

            }
            else if (this.Select16HX.Checked)
            {
                receiveString = byteToHexstr(receiveBuffer);
            }

            if (this.huanhang.Checked)
            {
                receiveString += "\r\n"; // 添加换行符
            }

            // 线程安全的显示接收数据
            if (this.txtReceiveData.InvokeRequired)
            {
                // 使用委托进行线程间调用
                this.txtReceiveData.Invoke(new Action(() =>
                {
                    txtReceiveData.AppendText(receiveString);
                }));
            }
            else
            {
                txtReceiveData.AppendText(receiveString);
            }
        }

        /// <summary>
        /// Byte数组转换为16进制字符串
        /// </summary>
        /// <param name="receiveBuffer"></param>
        /// <returns></returns>
        private string byteToHexstr(byte[] receiveBuffer)

        {
            // 将 Byte数组转换为16进制 用空格分隔
            StringBuilder sb = new StringBuilder();
            foreach (byte b in receiveBuffer)
            {
                sb.Append(b.ToString("X2") + " ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// 将字符串转为16进制字节数组
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private byte[] HexstrToBytes(string text)
        {
            text = text.Replace(" ", "");
            if (text.Length % 2 != 0)
            {
                text += "";
            }
            byte[] buffer = new byte[text.Length / 2];
            for (int i = 0; i < text.Length; i++)
            {
                string sub = text.Substring(i * 2, 2);  // 每两个字符取一段
                buffer[i] = Convert.ToByte(sub, 16); // 转化为16进制
            }

            return buffer;
        }

        /// <summary>
        /// 发送数据按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {

            if (portIsOpen == false)
            {
                MessageBox.Show("请先打开串口！");
                return;
            }
            if (this.sendData.Text.Length == 0)
            {
                MessageBox.Show("不能发送空信息！");
                return;
            }
            try
            {
                Byte[] sendbuf = null;
                if (Select16HX.Checked)
                {
                    // 将16进制字符串转为字节数组
                    sendbuf = HexstrToBytes(this.sendData.Text);
                }
                else if (SelectString.Checked)
                {
                    sendbuf = Encoding.UTF8.GetBytes(this.sendData.Text);
                }
                serialPort.Write(sendbuf, 0, sendbuf.Length);

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据发送失败：" + ex.Message);
            }

        }

        /// <summary>
        /// 清空接收数据按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearData_Click(object sender, EventArgs e)
        {
            this.txtReceiveData.Clear();
        }
    }
}
