using SimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        int check = 0;
        SimpleTcpClient Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void open()
        {
            //((Control)this.show).Enabled = true;
            ((Control)this.show).Invoke(new Action(() =>
            {
                ((Control)this.show).Enabled = true;
            }));
            Client.Send("Allresult");

            MainControl.Invoke(new Action(() =>
            {
                MainControl.SelectedTab = MainControl.TabPages["show"];
            }));

            ((Control)this.LoginPage).Invoke(new Action(() =>
            {
                ((Control)this.LoginPage).Enabled = false;
            }));

            ((Control)this.CreatePage).Invoke(new Action(() =>
            {
                ((Control)this.CreatePage).Enabled = false;
            }));
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) && (!string.IsNullOrEmpty(Password.Text)))
            {
                Client.Send($"Login:{Username.Text}%{Password.Text}");
                MessageFromServer.Text += $"Me:LogIn:{Username.Text}%{Password.Text}{Environment.NewLine}";
            }
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string Str_Check = Encoding.UTF8.GetString(e.Data);
            if (Str_Check == "Invalid")
            {
                MessageBox.Show("Your Username or Password is invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Str_Check == "Invalid1")
            {
                MessageBox.Show("Your Acccount has Registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Str_Check == "Success1")
            {
                MessageBox.Show("You have registers successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (Str_Check == "Success")
            {
                MessageBox.Show("You have connected", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                check -= 1;
                open();
            }
            else if (Str_Check == "All_Result*")
            {
                LoadData(11, Str_Check);
            }
            else if (Str_Check == "All_Result1*")
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

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            btnSignIn.Enabled = false;
            btnConnect.Enabled = false;
            ((Control)show).Enabled = false;
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
          /*List<tabledata> resultlist = listData.Instance.Load(h, check_string);
            int i = 0;

            guna2DataGridView1.Invoke(new Action(() => { guna2DataGridView1.Rows.Clear(); }));
            guna2DataGridView1.Invoke(new Action(() => { guna2DataGridView1.Refresh(); }));
            foreach (tabledata item in resultlist)
            {
                guna2DataGridView1 row = 
            } */
        }


        private void CreateClient_Click_2(object sender, EventArgs e)
        {

        }

        private void CreateClient_Click_3(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextIP.Text))
            {
                Client = new SimpleTcpClient($"{TextIP.Text}:{TextPort.Text}");
                Client.Events.Connected += Events_Connected;
                Client.Events.Disconnected += Events_Disconnected;
                Client.Events.DataReceived += Events_DataReceived;
                btnConnect.Enabled = true;
                CreateClient.Enabled = false;
            }
            else
            {
                MessageBox.Show("IP server is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Connect();
                btnCreate.Enabled = true;
                btnSignIn.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text))
            { 
                Client.Send($"1*{Username.Text.Length.ToString()}*{Username.Text}*{Password.Text.Length.ToString()}*{Password.Text}");
                MessageFromServer.Text += $"Me:Login{Username.Text}%{Password.Text}";
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            {
                if ((!string.IsNullOrEmpty(createUser.Text)) && (!string.IsNullOrEmpty(createPass.Text)) && (!string.IsNullOrEmpty(creatRePass.Text)))
                {
                    if (creatRePass.Text.ToString() == createPass.Text.ToString())
                    {
                        Client.Send($"2*:{createUser.Text.Length.ToString()}*{createUser.Text}*{createPass.Text.Length.ToString()}*{createPass.Text}");
                        MessageFromServer.Text += $"Me:Create:{createUser.Text}%{createPass.Text}{Environment.NewLine}";
                    }
                    else
                    {
                        MessageBox.Show("Re_pass is invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
