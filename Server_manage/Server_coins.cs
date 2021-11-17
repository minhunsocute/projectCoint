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

        private void Events_DataRecceived(object sender, DataReceivedEventArgs e){
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e){
       
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e){
        }
        //https://stackoverflow.com/questions/41683798/convert-json-from-get-request-into-text-boxes-in-c-sharp-winforms-application
    }
}
