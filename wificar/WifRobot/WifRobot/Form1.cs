using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace WifiVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //serialPort1.Encoding = Encoding.GetEncoding("GB2312");                                  //串口接收编码
            //为串口绑定接收数据事件  
            this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        static string FileName = Application.StartupPath + "\\Config.ini";
        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        string CameraIp = "";
        string ControlIp = "192.168.1.1";
        string Port = "81";
        string CMD_Forward = "", CMD_Backward = "", CMD_TurnLeft = "", CMD_TurnRight = "", CMD_Stop = "", CMD_EngineUp = "", CMD_EngineDown = "", CMD_textLightsOn = "", CMD_textLightsOff = "";


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = CameraIp;// "http://192.168.1.1:8080/?action=snapshot";
        }

        void SendData(string data)
        {
            try
            {
                IPAddress ips = IPAddress.Parse(ControlIp.ToString());//("192.168.2.1");
                IPEndPoint ipe = new IPEndPoint(ips, Convert.ToInt32(Port.ToString()));//把ip和端口转化为IPEndPoint实例
                Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket

                c.Connect(ipe);//连接到服务器

                byte[] bs = Encoding.ASCII.GetBytes(data);
                c.Send(bs, bs.Length, 0);//发送测试信息
                c.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendData(CMD_Forward);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendData(CMD_Backward);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnLeft);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendData(CMD_TurnRight);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Config cfg = new Config();
            cfg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIni();
            buttonForward.BackColor = Color.LightBlue;
            buttonBackward.BackColor = Color.LightBlue;
            buttonLeft.BackColor = Color.LightBlue;
            buttonRight.BackColor = Color.LightBlue;
            buttonStop.BackColor = Color.LightBlue;
            btnEngineUp.BackColor = Color.LightBlue;
            btnEngineDown.BackColor = Color.LightBlue;
            btnLightsOn.BackColor = Color.LightBlue;
            btnLightsOff.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;
            button1.BackColor = Color.LightBlue;
        }
        private void GetIni()
        {
            CameraIp = ReadIni("VideoUrl", "videoUrl", "");
            ControlIp = ReadIni("ControlUrl", "controlUrl", "");
            Port = ReadIni("ControlPort", "controlPort", "");
            CMD_Forward = ReadIni("ControlCommand", "CMD_Forward", "");
            CMD_Backward = ReadIni("ControlCommand", "CMD_Backward", "");
            CMD_TurnLeft = ReadIni("ControlCommand", "CMD_TurnLeft", "");
            CMD_TurnRight = ReadIni("ControlCommand", "CMD_TurnRight", "");
            CMD_Stop = ReadIni("ControlCommand", "CMD_Stop", "");
            CMD_EngineUp = ReadIni("ControlCommand", "CMD_EngineUp", "");
            CMD_EngineDown = ReadIni("ControlCommand", "CMD_EngineDown", "");
            CMD_textLightsOn = ReadIni("ControlCommand", "CMD_textLightsOn", "");
            CMD_textLightsOff = ReadIni("ControlCommand", "CMD_textLightsOff", "");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Saomiao(serialPort1, comboBox1);
            button3.Enabled = true;

        }

        private void Saomiao(SerialPort MyPort, ComboBox MyBox)
        {
            string[] MyString = new string[20];
            string Buffer;
            MyBox.Items.Clear();
            for (int i = 1; i < 20; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                    MyPort.Open();
                    MyString[i - 1] = Buffer;
                    MyBox.Items.Add(Buffer);
                    MyPort.Close();
                }
                catch
                {

                }
            }
            MyBox.Text = MyString[0];
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                }
                catch { }
                button3.Text = "打开串口";
                button2.Enabled = true;

            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    button3.Text = "关闭串口";
                    button2.Enabled = false;


                }
                catch
                {
                    MessageBox.Show("串口打开失败", "错误");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();

            savefiledialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";

            string filepath = "";

            string totext = "";

            if (savefiledialog1.ShowDialog() == DialogResult.OK)

            {

                for (int i = 0; i < listBox1.Items.Count; i++)

                {

                    totext += listBox1.Items[i] + "\r\n";

                }

                filepath = savefiledialog1.FileName;

                StreamWriter sw = new StreamWriter(filepath);

                sw.Write(totext);

                sw.Flush();

                sw.Close();

                MessageBox.Show(savefiledialog1.FileName);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                buttonForward.BackColor = Color.DarkGray;
                buttonForward.PerformClick();

            }
            else if (e.KeyCode == Keys.S)
            {
                buttonBackward.BackColor = Color.DarkGray;
                buttonBackward.PerformClick();

            }
            else if (e.KeyCode == Keys.A)
            {
                buttonLeft.BackColor = Color.DarkGray;
                buttonLeft.PerformClick();

            }
            else if (e.KeyCode == Keys.D)
            {
                buttonRight.BackColor = Color.DarkGray;
                buttonRight.PerformClick();

            }
            else if (e.KeyCode == Keys.X)
            {
                buttonStop.BackColor = Color.DarkGray;
                buttonStop.PerformClick();

            }
            else if (e.KeyCode == Keys.I)
            {
                btnEngineUp.BackColor = Color.DarkGray;
                btnEngineUp.PerformClick();

            }
            else if (e.KeyCode == Keys.K)
            {
                btnEngineDown.BackColor = Color.DarkGray;
                btnEngineDown.PerformClick();

            }
            else if (e.KeyCode == Keys.F)
            {
                btnLightsOn.BackColor = Color.DarkGray;
                btnLightsOn.PerformClick();
            }
            else if (e.KeyCode == Keys.G)
            {
                btnLightsOff.BackColor = Color.DarkGray;
                btnLightsOff.PerformClick();

            }
            else if (e.KeyCode == Keys.F2)
            {
                button6.BackColor = Color.DarkGray;
                button6.PerformClick();

            }
            else if (e.KeyCode == Keys.F1)
            {
                button1.BackColor = Color.DarkGray;
                button1.PerformClick();

            }
        }






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            buttonStop.PerformClick();
            buttonForward.BackColor = Color.LightBlue;
            buttonBackward.BackColor = Color.LightBlue;
            buttonLeft.BackColor = Color.LightBlue;
            buttonRight.BackColor = Color.LightBlue;
            btnEngineUp.BackColor = Color.LightBlue;
            btnEngineDown.BackColor = Color.LightBlue;
            btnLightsOn.BackColor = Color.LightBlue;
            btnLightsOff.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;
            button1.BackColor = Color.LightBlue;
        }

        private void btnEngineUp_Click(object sender, EventArgs e)
        {
            SendData(CMD_EngineUp);
            btnEngineDown.Enabled = true;
            btnEngineUp.Enabled = false;
            buttonForward.Enabled = false;
            buttonStop.Enabled = false;
            buttonBackward.Enabled = false;
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;

        }

        private void btnEngineDown_Click(object sender, EventArgs e)
        {
            SendData(CMD_EngineDown);
            btnEngineDown.Enabled = false;
            btnEngineUp.Enabled = true;
            buttonForward.Enabled = true;
            buttonStop.Enabled = true;
            buttonBackward.Enabled = true;
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SendData(CMD_Stop);
        }



        private void btnLightsOff_Click(object sender, EventArgs e)
        {
            SendData(CMD_textLightsOff);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = false;
            label14.Text = "已启用";
            label14.ForeColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            button8.Enabled = false;
            label14.Text = "未启用";
            label14.ForeColor = Color.Red;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLightsOn_Click_1(object sender, EventArgs e)
        {
            SendData(CMD_textLightsOn);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*
                //接收串口数据函数  

                private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
                {

                            String nowtime = DateTime.Now.ToString();

                            StringBuilder builder = new StringBuilder();
                            int n = serialPort1.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
                            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
                            //n += n;//增加接收计数  
                            serialPort1.Read(buf, 0, n); ;//读取缓冲数据  
                            builder.Clear();//清除字符串构造器的内容  
                                            //因为要访问ui资源，所以需要使用invoke方式同步ui。  
                            this.Invoke((EventHandler)(delegate
                            {
                                //直接按ASCII规则转换成字符串  
                                builder.Append(Encoding.ASCII.GetString(buf));
                                //追加的形式添加到文本框末端，并滚动到最后。  
                               this.listBox1.Items.Add(nowtime + "=> " + builder.ToString()  + Environment.NewLine);
                               this.listBox1.TopIndex = this.listBox1.Items.Count - (int)(this.listBox1.Height / this.listBox1.ItemHeight);

                                //string a = builder.ToString();
                                //string mingzi = a.Substring(0, 3);
                                //string shuju = a.Substring(3, 5);
                                //panduananquan(mingzi ,shuju);//判断名字和数据

                            }));


                            SerialPort sp = (SerialPort)sender;
                            string indata = sp.ReadExisting();


                }*/
        private List<byte> buffer = new List<byte>(4096);

        private void DataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            byte[] readBuffer = null;
            int n = serialPort1.BytesToRead;
            byte[] buf = new byte[n];
            serialPort1.Read(buf, 0, n);
            //1.缓存数据          
            buffer.AddRange(buf);
            //2.完整性判断        
            while (buffer.Count >= 7)
            {
                //至少包含标头(1字节),长度(1字节),校验位(2字节)等等
                //2.1 查找数据标记头           
                if (buffer[0] == 0x7B) //传输数据有帧头，用于判断      
                {

                    if (buffer.Count < 10)
                    {
                        //数据未接收完整跳出循环
                        break;
                    }
                    readBuffer = new byte[10];
                    //得到完整的数据，复制到readBuffer中   
                    buffer.CopyTo(0, readBuffer, 0, 10);
                    //从缓冲区中清除
                    buffer.RemoveRange(0, 10);



                    //触发外部处理接收消息事件
                    string str = System.Text.Encoding.ASCII.GetString(readBuffer);
                    dayinshuju(str);


                }


                else //开始标记或版本号不正确时清除          
                {
                    buffer.RemoveAt(0);
                }
            }


        }
        
        private void dayinshuju(string str)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int  fanhuizhi =0;
            int i = 1;

            for ( i = 1; i < 9; i++)
            {

                if (fanhuizhi == 0)
                {
                    if (ch[i] < 48 || ch[i] > 57)
                    {
                        fanhuizhi = 1;
                        goto cc;
                    }
                    else
                    {
                        fanhuizhi = 0;

                    }



                }

            }

            if (fanhuizhi == 0)
            {
                string mingzi = str.Substring(1, 3);
                string shuju = str.Substring(4, 5);
                Panduananquan(mingzi, shuju);
            }

            //string s1 = fanhuizhi.ToString();
            //string s2 = Convert.ToString(fanhuizhi);
            //MessageBox.Show(s2, "终");


            this.listBox1.Items.Add("=> " + str + Environment.NewLine);
            this.listBox1.TopIndex = this.listBox1.Items.Count - (int)(this.listBox1.Height / this.listBox1.ItemHeight);
            cc:;
        }




        string fankui;
        private void Panduananquan(string mingzi, string shuju)
        {

            switch (mingzi)
            {
                case "008":
                    zhangaipanduan(shuju);//前判断数据大小
                    label8.Text = fankui;
                    break;
                case "004":
                    zhangaipanduan(shuju);//后判断数据大小
                    label9.Text = fankui;
                    break;
                case "006":
                    zhangaipanduan(shuju);//左判断数据大小
                    label10.Text = fankui;
                    break;
                case "002":
                    zhangaipanduan(shuju);//右判断数据大小
                    label11.Text = fankui;
                    break;
                case "001":
                    panduansudu(shuju);

                    break;


                default:

                    break;
            }


        }

        private void panduansudu(string shuju)
        {
            float shuzi2 = Convert.ToSingle(shuju);
            float shuzi3 = shuzi2 / 100;
            label3.Text = shuzi3+ "";
        }

        private void zhangaipanduan(string shuju)
        {
            
            float shuzi1 = Convert.ToSingle(shuju);
            float shuzi = shuzi1 / 100;
            if (shuzi < 0.0 || shuzi >= 100.0)
            {
                fankui = "无障碍";
                label12.Text = "安   全";
                label12.ForeColor = Color.Green;
            }
            else if (shuzi < 100.0)
            {
                if (shuzi > 15.0)
                {
                    fankui = "离障碍" + shuzi + "cm";
                    label12.Text = "安   全";
                    label12.ForeColor = Color.Green;
                }
                else if (shuzi <= 15.0)
                {
                    fankui = "危险,停车";
                    label12.Text = fankui;
                    label12.ForeColor = Color.Red;
                    if (button7.Enabled == false)
                    {
                        label14.Text = "已停车";
                        label14.ForeColor = Color.Red;

                    }
                }
            }
        }
    }
}

