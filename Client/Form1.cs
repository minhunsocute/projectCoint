using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        int check = 0; 
        string table_data = "";
        public SimpleTcpClient Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open()
        {

        }
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Username.Text) && (!string.IsNullOrEmpty(Password.Text)))
            {
                Client.Send($"Login:{Username.Text}%{Password.Text}");
                MessageFromServer.Text += $"Me:LogIn:{Username.Text}%{Password.Text}{Environment.NewLine}";
            }
        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextIP.Text))
            {
                Client = new SimpleTcpClient($"{TextIP.Text}:{TextPort.Text}");
                Client.Events.Connected += Events_Connected;
                Client.Events.Disconnected += Events_Disconnected;
                Client.Events.DataReceived += Events_DaraReceived;
                ConnectAgain.Enabled = true;
                CreateClient.Enabled = false;
            }
            else
            {
                MessageBox.Show("IP server is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void Events_DaraReceived(object sender, DataReceivedEventArgs e)
        {
            string Str_Check = Encoding.UTF8.GetString(e.Data);
            if(Str_Check == "Invalid")
            {
                MessageBox.Show("Your Username or Password is invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Str_Check == "Invalid1")
            {
                MessageBox.Show("Your Acccount has Registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Str_Check == "Success1")
            {
                MessageBox.Show("You have registers successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if(Str_Check == "Success")
            {
                MessageBox.Show("You have connected", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                check -= 1;
                Open();
            }
            else if(Str_Check == "All_Result*")
            {
                LoadData(11, Str_Check);
            }
            else if(Str_Check == "All_Result1*")
            {
                LoadData(12, Str_Check);
            }
            throw new NotImplementedException();
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            try
            {
                MessageFromServer.Text += $"Server is disconnected.{Environment.NewLine}";
            }
            catch
            {
                MessageBox.Show("Server is disconnected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            throw new NotImplementedException();
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            MessageFromServer.Text += $"Server is connected.{Environment.NewLine}";
            throw new NotImplementedException();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateClient_Click_1(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadData(int h, string check_string)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NewUser.Text) && !string.IsNullOrEmpty(NewPass.Text) && !string.IsNullOrEmpty(RePass.Text))
            {
                if(RePass.Text == NewPass.Text)
                {
                    Client.Send($"Create:{NewUser.Text} % {NewPass.Text}");
                    MessageFromServer.Text += $"Me:Create:{NewUser.Text}%{NewPass.Text}{Environment.NewLine}";
                }
                else
                {
                    MessageBox.Show("Re Pass is invalid, please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Input is empty!","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
