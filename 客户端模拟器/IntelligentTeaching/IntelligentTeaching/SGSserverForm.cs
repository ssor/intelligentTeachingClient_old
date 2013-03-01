using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace IntelligentTeaching
{
    public partial class SGSserverForm : Form
    {
        //The ClientInfo structure holds the required information about every
        //client connected to the server
        struct ClientInfo
        {
            public Socket socket;   //Socket of the client
            public string strName;  //Name by which the user logged into the chat room
        }
        bool bServiceClosed = true;
        //The collection of all clients logged into the room (an array of type ClientInfo)
        ArrayList clientList;

        //The main socket on which the server listens to the clients
        Socket serverSocket;

        byte[] byteData = new byte[1024];

        public SGSserverForm()
        {
            clientList = new ArrayList();
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(SGSserverForm_FormClosing);
        }

        void SGSserverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bServiceClosed == false)
            {
                MessageBox.Show("���ȹرշ���");
                e.Cancel = true;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int portNum = 13000;
                if (this.txtPort.Text != null)
                {
                    if (Regex.IsMatch(this.txtPort.Text, @"\d[1-9]\d{1,4}"))
                    {
                        portNum = int.Parse(this.txtPort.Text);
                    }
                }
                IPAddress ipAddress = null;
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                for (int i = 0; i < ipHostInfo.AddressList.Length; i++)
                {
                    ipAddress = ipHostInfo.AddressList[i];
                    if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        break;
                    }
                    else
                    {
                        ipAddress = null;
                    }
                }
                if (null == ipAddress)
                {
                    return;
                }
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, portNum);
                //We are using TCP sockets
                serverSocket = new Socket(AddressFamily.InterNetwork,
                                          SocketType.Stream,
                                          ProtocolType.Tcp);

                //Assign the any IP of the machine and listen on port number 1000
                //IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, portNum);

                //Bind and listen on the given address
                serverSocket.Bind(localEndPoint);
                serverSocket.Listen(4);

                //Accept the incoming clients
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);
                txtLog.Text += string.Format("{0}({1}:{2}) �ȴ�����....) \r\n", Dns.GetHostName(), ipAddress.ToString(), portNum.ToString());
                this.bServiceClosed = false;
                //txtLog.Text += ipAddress.ToString() + ":" + portNum.ToString() + "Waiting... \r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (null != serverSocket)
            {
                try
                {
                    if (serverSocket.Connected)
                    {
                        serverSocket.Shutdown(SocketShutdown.Both);
                    }
                    serverSocket.Close();
                    serverSocket = null;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
            this.bServiceClosed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
        }

        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                if (null != serverSocket)
                {
                    Socket clientSocket = serverSocket.EndAccept(ar);

                    //Start listening for more clients
                    serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                    //Once the client connects then start receiving the commands from her
                    clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                        new AsyncCallback(OnReceive), clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                //Transform the array of bytes received from the user into an
                //intelligent form of object Data
                Data msgReceived = new Data(byteData);
                txtLog.Invoke(new deleControlInvoke(this.UpdateTxtLog), msgReceived);
                clientSocket.Close();
                //clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
        try
        {
            Socket clientSocket = (Socket)ar.AsyncState;
            clientSocket.EndReceive(ar);

            //Transform the array of bytes received from the user into an
            //intelligent form of object Data
            Data msgReceived = new Data(byteData);


           //We will send this object in response the users request
            Data msgToSend = new Data();

            byte [] message;
                
            //If the message is to login, logout, or simple text message
            //then when send to others the type of the message remains the same
            msgToSend.cmdCommand = msgReceived.cmdCommand;
            msgToSend.strName = msgReceived.strName;

            switch (msgReceived.cmdCommand)
            {
                case Command.Login:
                        
                    //When a user logs in to the server then we add her to our
                    //list of clients

                    ClientInfo clientInfo = new ClientInfo();
                    clientInfo.socket = clientSocket;      
                    clientInfo.strName = msgReceived.strName;

                    clientList.Add(clientInfo);
                        
                    //Set the text of the message that we will broadcast to all users
                    msgToSend.strMessage =  msgReceived.strName + " ���뵽������";   
                    break;

                case Command.Logout:                    
                        
                    //When a user wants to log out of the server then we search for her 
                    //in the list of clients and close the corresponding connection

                    int nIndex = 0;
                    foreach (ClientInfo client in clientList)
                    {
                        if (client.socket == clientSocket)
                        {
                            clientList.RemoveAt(nIndex);
                            break;
                        }
                        ++nIndex;
                    }
                        
                    clientSocket.Close();
                        
                    msgToSend.strMessage =msgReceived.strName + " �Ѿ��뿪������";
                    break;

                case Command.Message:

                    //Set the text of the message that we will broadcast to all users
                    msgToSend.strMessage = msgReceived.strName + ": " + msgReceived.strMessage;
                    break;

                case Command.List:

                    //Send the names of all users in the chat room to the new user
                    msgToSend.cmdCommand = Command.List;
                    msgToSend.strName = null;
                    msgToSend.strMessage = null;

                    //Collect the names of the user in the chat room
                    foreach (ClientInfo client in clientList)
                    {
                        //To keep things simple we use asterisk as the marker to separate the user names
                        msgToSend.strMessage += client.strName + "*";   
                    }

                    message = msgToSend.ToByte();

                    //Send the name of the users in the chat room
                    clientSocket.BeginSend(message, 0, message.Length, SocketFlags.None,
                            new AsyncCallback(OnSend), clientSocket);                        
                    break;
            }

            if (msgToSend.cmdCommand != Command.List)   //List messages are not broadcasted
            {
                message = msgToSend.ToByte();

                foreach (ClientInfo clientInfo in clientList)
                {
                    if (clientInfo.socket != clientSocket ||
                        msgToSend.cmdCommand != Command.Login)
                    {
                        //Send the message to all users
                        clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None,
                            new AsyncCallback(OnSend), clientInfo.socket);                            
                    }
                }

                //txtLog.Text += msgToSend.strMessage + "\r\n";
                txtLog.Invoke(new deleControlInvoke(this.UpdateTxtLog), msgToSend);
            }

            //If the user is logging out then we need not listen from her
            if (msgReceived.cmdCommand != Command.Logout)
            {
                //Start listening to the message send by the user
                clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
           */
        }
        void UpdateTxtLog(object o)
        {
            Data msgToSend = (Data)o;
            txtLog.Text = txtLog.Text + msgToSend.toString() + "\r\n";
        }
        public void OnSend(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}