using System;
using SimpleTcp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server_manage
{   
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        List<string> listClient = new List<string>();
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            btnClose.Enabled = false;
        }
        //Tạo data tự động lấy từ json mỗi khi mở app
        private void Form1_Load(object sender, EventArgs e)
        {
            //           autoDataToSql();   
            listClient = new List<string>();
        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextIP.Text)) {
                /*try {  
                    btnClose.Enabled = true;
                    CreateClient.Enabled = false;
                    server = new SimpleTcpServer(TextIP.Text);
                    server.Events.ClientConnected += Events_ClientConnected;
                    server.Events.ClientDisconnected += Events_ClientDisconnected;
                    server.Events.DataReceived += Events_DataRecceived;
                    server.Start();
                    textIFO.Text += $"Startting .....{Environment.NewLine}";// create new line when have messsage;
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                coneect();

            }
            else
                MessageBox.Show("textIp is NULL", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /*}
        private void checkString(string s,DataReceivedEventArgs e) {
            sql_manage f = new sql_manage();
            textIFO.Text += $"{e.IpPort}:{s}{Environment.NewLine}";
            if (s[0] == '1') {
                if (f.checkLogin(s) == -1)
                    server.Send(e.IpPort, "1Success");//Đăng nhập thành công
                else
                    server.Send(e.IpPort, "2Invalid");//Đăng nhập không thành công
            }
            else if (s[0] == '2') {
                if (f.checkLogin(s) == -1)
                    server.Send(e.IpPort, "3Invalid");//Đăng ký không thành công
                else {
                    f.Insert_Account(s);
                    server.Send(e.IpPort, "4Success");//Đăng ký thành công
                }
            }
            else if (s[0] == '3'){ //In ra toàn bộ giá trị của bảng 
                string sendString = f.GetDataFromDatabase("", "");
                server.Send(e.IpPort,sendString);
            }
        }
        private void Events_DataRecceived(object sender, DataReceivedEventArgs e){
            checkString(Encoding.UTF8.GetString(e.Data), e);
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e){
            listClientText.Text = string.Empty;
            textIFO.Text += $"{e.IpPort}:Disconnected{Environment.NewLine}";
            int i = 0;
            foreach(string item in listClient) { 
                if(item == e.IpPort) {
                    listClient.RemoveAt(i);
                    break;
                }
                i++;
            }
            foreach (string item in listClient)
                listClientText.Text += $"{item}{Environment.NewLine}";
        }
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e){
            textIFO.Text += $"{e.IpPort}:Connected{Environment.NewLine  }";
            listClient.Add(e.IpPort);
            listClientText.Text += $"{e.IpPort}{Environment.NewLine}";
        }
        private void btnClose_Click(object sender, EventArgs e) { 
            
        }*/
        //https://stackoverflow.com/questions/41683798/convert-json-from-get-request-into-text-boxes-in-c-sharp-winforms-application
        
        
        
        
        //Xử lý Socket serve
        IPEndPoint IP;
        Socket Server1;
        List<Socket> ClientList;
        //Xử lý server tạo 1 socket để Client kết nối
        private void coneect() {
            ClientList = new List<Socket>();
            string textP = "";string textPort = "";
            int Index = TextIP.Text.IndexOf(':');
            textP = TextIP.Text.Substring(0, Index - 1);
            textPort = TextIP.Text.Substring(Index + 1);
            IP = new IPEndPoint(IPAddress.Any, Int32.Parse(textPort));
            Server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Server1.Bind(IP);textIFO.Text += "Starting.............";
            Thread Listen = new Thread(() =>
            {
                try {
                    while (true) {
                        Server1.Listen(100);
                        Socket clien = Server1.Accept();
                        ClientList.Add(clien);
                        textIFO.Text += $"{clien.RemoteEndPoint.ToString()}:Connected{Environment.NewLine}";
                        listClientText.Text += $"{clien.RemoteEndPoint.ToString()}{Environment.NewLine}";
                        Thread rec = new Thread(Receive);
                        rec.IsBackground = true;
                        rec.Start(clien);
                    }
                }
                catch{
                    IP = new IPEndPoint(IPAddress.Parse(textP), Int32.Parse(textPort));
                    Server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        //Hàm nhận dữ liệu từ client
        private void Receive(object obj){
            Socket clien = (Socket)obj;
            try {
                while (true) {
                    byte[] data = new byte[1024 * 5000];
                    clien.Receive(data);
                    string mess = (string)Deserialize(data);
                    textIFO.Text += $"{clien.RemoteEndPoint.ToString()}:{mess}{Environment.NewLine}";
                    checkString1(mess, clien);
                }
            }
            catch { }
        }
        //Hàm gửi Dữ liệu cho client 
        private void sendString(Socket clien,string s) { 
            foreach(Socket item in ClientList) {
                if (item.RemoteEndPoint.ToString() == clien.RemoteEndPoint.ToString()) { 
                    clien.Send(Serialize(s));
                    break;
                }
            }
        }
        //Hàm kiểm tra dữ liệu để server lấy dữ liệu và gửi cho client phù hợp với yêu cầu của client
        private void checkString1(string s,Socket clien) {
            sql_manage f = new sql_manage();
            if (s[0] == '1') {
                if (f.checkLogin(s) == -1) {
                    sendString(clien, "1Success");//Đăng nhập thành công
                }
                else {
                    sendString(clien, "2Invalid");//Đăng nhập không thành công
                }
            }
            else if (s[0] == '2') {
                if (f.checkLogin(s) == -1) {
                    sendString(clien, "3Invalid");//Đăng ký không thành công
                }
                else {
                    f.Insert_Account(s);
                    sendString(clien, "4Success");//Đăng ký thành công
                }
            }
            else if (s[0] == '3'){ //In ra toàn bộ giá trị của bảng 
                string sendString1 = f.GetDataFromDatabase("", "");
                sendString(clien, sendString1);
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();// stream tra ra 1 day byte
        }
        // gom manh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}
