using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using IntelligentCarbinet;
using nsConfigDB;

namespace Carbinet
{
    static class Program
    {
        //相当于全局变量 
        public static frmSelect frmSelect = null;
        public static frmFloat frmFloat = null;
        public static frmMain frmMain = null;
        public static frmCheck frmCheck = null;
        public static frmRTTest frmTest = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initialConfig();
            frmMain = new frmMain();
            //frmCheck = new frmCheck();
            frmSelect = new frmSelect();
            //frmTest = new frmRTTest();
            frmMainFloat frmStart = new frmMainFloat();
            //frmCheckInit frmStart = new frmCheckInit();
            //frmCheckStatics frmStart = new frmCheckStatics();
            Application.Run(frmStart);
            //Application.Run(frmMain);
            //Application.Run(new Form1());
            //Application.Run(new frmLogin());
            //Program.compareString();
        }
        public static void initialConfig()
        {
            object o1 = ConfigDB.getConfig("restIP");
            if (o1 != null)
            {
                staticClass.restIP = o1 as string;
            }
            object o2 = ConfigDB.getConfig("restPort");
            if (o2 != null)
            {
                staticClass.restPort = o2 as string;
            }
            object o3 = ConfigDB.getConfig("serial_port_name");
            if (o3 != null)
            {
                staticClass.serial_port_name = o3 as string;
            }
        }
        public static void compareString()
        {
            string str1 = "abc";
            string str2 = "ABC";
            string str3 = "bca";
            int i = string.CompareOrdinal(str1, str3);
            Debug.WriteLine(
                string.Format("Program.compareString  -> abc vs bca = {0}"
                , i.ToString()));
        }
    }
}
