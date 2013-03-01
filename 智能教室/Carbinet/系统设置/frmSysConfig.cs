using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO.Ports;
using Carbinet;

namespace IntelligentCarbinet
{
    public partial class frmSysConfig : Form
    {
        public frmSysConfig()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cmbPortName.Items.AddRange(ports);

            this.Shown += new EventHandler(frmSysConfig_Shown);
            this.Load += new EventHandler(frmSysConfig_Load);
        }

        void frmSysConfig_Load(object sender, EventArgs e)
        {
            this.txtrestPort.Text = staticClass.restPort;
            this.txtIP.Text = staticClass.restIP;
        }

        void frmSysConfig_Shown(object sender, EventArgs e)
        {
            this.cmbPortName.Text = staticClass.serial_port_name;
            
        }

        bool checkValidation()
        {
            bool bR = true;

            if (this.txtIP.Text == null || this.txtIP.Text == string.Empty)
            {
                MessageBox.Show("必须填写读写器IP地址!", "异常提示");
                return false;
            }
            else
            {
                try
                {
                    string str = this.txtIP.Text;
                    IPAddress ip = IPAddress.Parse(str);
                    //MessageBox.Show("IP地址填写不符合规定!", "异常提示");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("IP地址填写不符合规定，" + ex.Message, "异常提示");
                    return false;
                }

            }
            if (this.txtrestPort.Text == null || this.txtrestPort.Text == string.Empty)
            {
                MessageBox.Show("必须填写读写器IP地址!", "异常提示");
                return false;
            }
            else
            {
                try
                {
                    string str = this.txtrestPort.Text;
                    int port = int.Parse(str);
                    //MessageBox.Show("端口填写不符合规定!", "异常提示");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("端口填写不符合规定，" + ex.Message, "异常提示");
                    return false;
                }

            }
            return bR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkValidation() == true)
            {
                nsConfigDB.ConfigDB.saveConfig("serial_port_name", this.cmbPortName.Text);
                nsConfigDB.ConfigDB.saveConfig("restIP", this.txtIP.Text);
                nsConfigDB.ConfigDB.saveConfig("restPort", this.txtrestPort.Text);

                staticClass.restPort = this.txtrestPort.Text;
                staticClass.restIP = this.txtIP.Text;
                staticClass.serial_port_name = this.cmbPortName.Text;

                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
