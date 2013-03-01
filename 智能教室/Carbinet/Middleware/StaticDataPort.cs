﻿//#define UDP_TRANSE
#define SERIAL_PORT_TRANSE
using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using Config;
using IntelligentCarbinet;

namespace intelligentMiddleWare
{
    public delegate void deleControlInvoke(object o);
    //public delegate void delevoid_bytes(byte[] bytes);
    //public delegate void delevoid_Data(Data data);
    //public delegate void delevoid_ProtocolHelper(ProtocolHelper helper);
    /// <summary>
    /// 提供一个统一的串口，防止多串口冲突
    /// 当一个页面只有一个串口时，一定要在页面关闭时关闭串口
    /// 当一个页面使用名义上的多个串口时，用完之后及时关闭
    /// </summary>
    public class StaticDataPort
    {
        //static string port_name = "com5";
        static bool bDataPortOpen = false;
        static int udp_server_port = 5000;
        static StringBuilder sbuilder = new StringBuilder();
#if UDP_TRANSE
        public static Socket serverSocket;

#endif

#if SERIAL_PORT_TRANSE
#endif
        static SerialPort comport = null;
        //static List<delevoid_Data> delegateDataList = new List<delevoid_Data>();
        //static List<delevoid_bytes> delegateList = new List<delevoid_bytes>();
        //public static delevoid_ProtocolHelper evtParseReceivedData;
        static byte[] byteData = new byte[1024];

        //public static void AddParser(delevoid_Data parser)
        //{
        //    if (!StaticDataPort.delegateDataList.Contains(parser))
        //    {
        //        StaticDataPort.delegateDataList.Add(parser);
        //    }
        //}
        //public static void AddParser(delevoid_bytes parser)
        //{
        //    if (!StaticDataPort.delegateList.Contains(parser))
        //    {
        //        StaticDataPort.delegateList.Add(parser);
        //    }
        //}
        //public static void removeParser(delevoid_Data parser)
        //{
        //    if (StaticDataPort.delegateDataList.Contains(parser))
        //    {
        //        StaticDataPort.delegateDataList.Remove(parser);
        //    }
        //}
        //public static void removeParser(delevoid_bytes parser)
        //{
        //    if (StaticDataPort.delegateList.Contains(parser))
        //    {
        //        StaticDataPort.delegateList.Remove(parser);
        //    }
        //}
        public static void openDataPort(string port_name, int baud_rate)
        {
            if (bDataPortOpen == true)
            {
                return;
            }
            try
            {
#if UDP_TRANSE
                initial_udp_server();
                IPEndPoint ipeSender = new IPEndPoint(IPAddress.Any, 0);
                //The epSender identifies the incoming clients
                EndPoint epSender = (EndPoint)ipeSender;

                //Start receiving data
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length,
                    SocketFlags.None, ref epSender, new AsyncCallback(OnReceive), epSender);

#endif

#if SERIAL_PORT_TRANSE

                if (!StaticDataPort.getStaticSerialPort(port_name, baud_rate).IsOpen)
                {
                    StaticDataPort.getStaticSerialPort(port_name, baud_rate).Open();
                }
#endif
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ",请检查后重启本系统", "信息提示", MessageBoxButtons.OK);
            }
            bDataPortOpen = true;
        }
        public static void openDataPort()
        {
            if (bDataPortOpen == true)
            {
                return;
            }
            try
            {
#if UDP_TRANSE
                initial_udp_server();
                IPEndPoint ipeSender = new IPEndPoint(IPAddress.Any, 0);
                //The epSender identifies the incoming clients
                EndPoint epSender = (EndPoint)ipeSender;

                //Start receiving data
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length,
                    SocketFlags.None, ref epSender, new AsyncCallback(OnReceive), epSender);

#endif

#if SERIAL_PORT_TRANSE
                //serialPortConfig config = serialPortConfig.getDefaultConfig();
                //if (config != null && config.portName.Length > 0)
                //{
                //    if (!StaticDataPort.getStaticSerialPort(config.portName, int.Parse(config.baudRate)).IsOpen)
                //    {
                //        StaticDataPort.getStaticSerialPort(config.portName, int.Parse(config.baudRate)).Open();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("串口打开失败，请先设置串口！", "信息提示", MessageBoxButtons.OK);
                //}
                if (!StaticDataPort.getStaticSerialPort(staticClass.serial_port_name, 19200).IsOpen)
                {
                    StaticDataPort.getStaticSerialPort(staticClass.serial_port_name, 19200).Open();
                }
#endif
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ",请检查后重启本系统", "信息提示", MessageBoxButtons.OK);
            }

            bDataPortOpen = true;
        }

        //关闭串口的时候必须考虑死锁问题
        public static void closeDataPort()
        {
#if SERIAL_PORT_TRANSE
            if (comport != null)
            {
                if (comport.IsOpen)
                {
                    comport.Close();
                }
            }
            //if (StaticDataPort.getStaticSerialPort("com5", 19200).IsOpen)
            //{
            //    StaticDataPort.getStaticSerialPort("com5", 19200).Close();
            //}
#endif
            sbuilder.Remove(0, sbuilder.Length);
        }

        #region Private Method
        static bool bUdp_server_initialed = false;
        private static void OnReceive(IAsyncResult ar)
        {
#if UDP_TRANSE

            try
            {
                IPEndPoint ipeSender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint epSender = (EndPoint)ipeSender;

                serverSocket.EndReceiveFrom(ar, ref epSender);

                string strReceived = Encoding.UTF8.GetString(byteData);

                Array.Clear(byteData, 0, byteData.Length);
                //int i = strReceived.IndexOf("\0");
                //todo here should deal with the received string
                sbuilder.Append(strReceived);
                string temp = string.Empty;
                while (true)
                {
                    temp = sbuilder.ToString();
                    if (temp == null || temp == string.Empty)
                    {
                        break;
                    }

                    int indexLeft = temp.IndexOf("[");
                    int indexRight = temp.IndexOf("]");
                    if (indexRight == -1 || indexLeft == -1)
                    {
                        break;
                    }
                    if (indexLeft >= indexRight)
                    {
                        //前面有数据错误
                        sbuilder.Remove(0, indexLeft);
                    }
                    else
                    {
                        string data = temp.Substring(indexLeft, indexRight - indexLeft + 1);
                        sbuilder.Remove(0, indexRight + 1);
                        ProtocolHelper p = ProtocolHelper.getProtocolHelper(data);
                        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                        backgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundThreadWork);
                        backgroundWorker1.RunWorkerAsync(p);
                    }
                }
                //Start listening to the message send by the user
                serverSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref epSender,
                    new AsyncCallback(OnReceive), epSender);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    string.Format("UDPServer.OnReceive  -> error = {0}"
                    , ex.Message));
            }
#endif
        }
        private static void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string temp = comport.ReadExisting();
                sbuilder.Append(temp);
                while (true)
                {
                    temp = sbuilder.ToString();
                    if (temp == null || temp == string.Empty)
                    {
                        break;
                    }

                    int indexLeft = temp.IndexOf("[");
                    int indexRight = temp.IndexOf("]");
                    if (indexRight == -1 || indexLeft == -1)
                    {
                        break;
                        //return;
                    }
                    if (indexLeft >= indexRight)
                    {
                        //前面有数据错误
                        sbuilder.Remove(0, indexLeft);
                    }
                    else
                    {
                        string data = temp.Substring(indexLeft, indexRight - indexLeft + 1);
                        sbuilder.Remove(0, indexRight + 1);
                        //Data dataTemp = new Data(data);
                        ProtocolHelper p = ProtocolHelper.getProtocolHelper(data);
                        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                        backgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundThreadWork);
                        backgroundWorker1.RunWorkerAsync(p);
                    }
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static void BackgroundThreadWork(object sender, DoWorkEventArgs e)
        {
            MiddleWareCore.Set_new_data((ProtocolHelper)e.Argument);
        }
        #endregion

        public static void initial_udp_server()
        {
#if UDP_TRANSE

            if (bUdp_server_initialed == true)
            {
                return;
            }
            serverSocket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ip, udp_server_port);
            //Bind this address to the server
            serverSocket.Bind(ipEndPoint);
            //防止客户端强行中断造成的异常
            long IOC_IN = 0x80000000;
            long IOC_VENDOR = 0x18000000;
            long SIO_UDP_CONNRESET = IOC_IN | IOC_VENDOR | 12;

            byte[] optionInValue = { Convert.ToByte(false) };
            byte[] optionOutValue = new byte[4];
            serverSocket.IOControl((int)SIO_UDP_CONNRESET, optionInValue, optionOutValue);

            bUdp_server_initialed = true;
#endif
        }
        public static SerialPort getStaticSerialPort(string port_name, int baut_rate)
        {
            if (StaticDataPort.comport == null)
            {
                StaticDataPort.comport = new SerialPort();
                comport.DataReceived += StaticDataPort.port_DataReceived;
                StaticDataPort.resetStaticSerialPort(port_name, baut_rate);//使用统一配置参数
            }
            return StaticDataPort.comport;
        }
        /// <summary>
        /// 这个函数使用统一的ConfigManager来配置串口参数，如果项目中没有ConfigManager类，需要将此函数注释
        /// </summary>
        public static void resetStaticSerialPort(string portName, int baudRate)
        {
            SerialPort sp = StaticDataPort.comport;
            if (sp == null)
            {
                return;
            }
            bool biniOpened = sp.IsOpen;
            if (biniOpened)
            {
                sp.Close();
            }
            try
            {
                sp.PortName = portName;
                sp.BaudRate = baudRate;
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show("配置文件出现错误！" + ex.Message);
            }
        }
        /// <summary>
        /// 串口关闭时可能引起线程死锁，因此这里要求首先安全关闭串口
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        public static void resetStaticSerialPort(string portName, string baudRate, string parity, string dataBits, string stopBits)
        {
            SerialPort sp = StaticDataPort.getStaticSerialPort(portName, int.Parse(baudRate));
            bool biniOpened = sp.IsOpen;
            if (biniOpened)
            {
                //sp.Close();
                MessageBox.Show("请先关闭串口！");
                return;
            }
            try
            {
                sp.PortName = portName;
                sp.BaudRate = int.Parse(baudRate);
                sp.DataBits = int.Parse(dataBits);
                sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("设置串口时出现异常错误！" + ex.Message);
            }
        }
    }
}
