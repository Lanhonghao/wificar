using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WifiVideo
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        public string FileName; //INI文件名
        //声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

        private void Config_Load(object sender, EventArgs e)
        {
            GetIni();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteIni("VideoUrl","videourl",this.textBoxVideo.Text);
            WriteIni("ControlUrl", "controlUrl", this.textControlURL.Text);
            WriteIni("ControlPort", "controlPort", this.textBoxControlPort.Text);
            WriteIni("ControlCommand", "CMD_Forward", this.txtForward.Text);
            WriteIni("ControlCommand", "CMD_Backward", this.txtBackward.Text);
            WriteIni("ControlCommand", "CMD_TurnLeft", this.txtLeft.Text);
            WriteIni("ControlCommand", "CMD_TurnRight", this.txtRight.Text);
            WriteIni("ControlCommand", "CMD_Stop", this.txtStop.Text);
            WriteIni("ControlCommand", "CMD_EngineUp", this.txtEngineUp.Text);
            WriteIni("ControlCommand", "CMD_EngineDown", this.txtEngineDown.Text);
            WriteIni("ControlCommand", "CMD_textLightsOn", this.textLightsOn.Text);
            WriteIni("ControlCommand", "CMD_textLightsOff", this.textLightsOff.Text);

            MessageBox.Show("配置成功！请重启程序以使配置生效。", "配置信息", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            this.Close();
        }
        //写INI文件
        public void WriteIni(string Section, string Ident, string Value)
        {
            if (!WritePrivateProfileString(Section, Ident, Value, FileName))
            {

                throw (new ApplicationException("写入配置文件出错"));
            }
          
        }
        //读取INI文件指定
        public string ReadIni(string Section, string Ident, string Default)
        {
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(Section, Ident, Default, Buffer, Buffer.GetUpperBound(0), FileName);
            //必须设定0（系统默认的代码页）的编码方式，否则无法支持中文
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }
        private void GetIni()
        {
            FileName = Application.StartupPath + "\\Config.ini";
            this.textBoxVideo.Text = ReadIni("VideoUrl", "videourl", "");
            this.textControlURL.Text = ReadIni("ControlUrl", "controlUrl", "");
            this.textBoxControlPort.Text = ReadIni("ControlPort", "controlPort", "");
            this.txtForward.Text = ReadIni("ControlCommand", "CMD_Forward", "");
            this.txtBackward.Text = ReadIni("ControlCommand", "CMD_Backward", "");
            this.txtLeft.Text = ReadIni("ControlCommand", "CMD_TurnLeft", "");
            this.txtRight.Text = ReadIni("ControlCommand", "CMD_TurnRight", "");
            this.txtStop.Text = ReadIni("ControlCommand", "CMD_Stop", "");
            this.txtEngineUp.Text = ReadIni("ControlCommand", "CMD_EngineUp", "");
            this.txtEngineDown.Text = ReadIni("ControlCommand", "CMD_EngineDown", "");
            this.textLightsOn.Text = ReadIni("ControlCommand", "CMD_textLightsOn", "");
            this.textLightsOff.Text = ReadIni("ControlCommand", "CMD_textLightsOff", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
