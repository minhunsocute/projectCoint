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


namespace Server_manage
{   
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        List<string> listClient = new List<string>();
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
        }
        //Tạo data tự động lấy từ json mỗi khi mở app
        private void autoDataToSql(){
            sql_manage.updateData();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //           autoDataToSql();   
            listClient = new List<string>();
        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextIP.Text)) {
                try {  
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
                }
            }
            else
                MessageBox.Show("textIp is NULL","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void checkString(string s,DataReceivedEventArgs e) {
            sql_manage f = new sql_manage();
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
        }
        private void Events_DataRecceived(object sender, DataReceivedEventArgs e){
            checkString(Encoding.UTF8.GetString(e.Data), e);
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e){
            listClientText.Text = string.Empty;
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
            listClient.Add(e.IpPort);
            listClientText.Text += $"{e.IpPort}{Environment.NewLine}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
        //https://stackoverflow.com/questions/41683798/convert-json-from-get-request-into-text-boxes-in-c-sharp-winforms-application
    }
}
