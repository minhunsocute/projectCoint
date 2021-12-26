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
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class client : Form
    {
        int check = 0;
        int check_LoadCombo = 0;
        IPEndPoint IP;
        Socket Client1;

        public client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        #region Connect 
        void Connect()
        {
            try
            {
                IP = new IPEndPoint(IPAddress.Parse(TextIP.Text), Int32.Parse(TextPort.Text));
                Client1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Client1.Connect(IP);
                this.Invoke(new Action(() =>
                {
                    CreateClient.Enabled = false;
                    btnSignIn.Enabled = true;
                    btnCreate.Enabled = true;
                }));
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
            }
            catch
            {
                MessageBox.Show("Cannot connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            btnSignIn.Enabled = false;
            ((Control)show).Enabled = false;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            ((Control)show).Enabled = false;
        }
        #endregion

        #region Even Click
        //Creat and connect to server
        private void CreateClient_Click_3(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextIP.Text)&&!string.IsNullOrEmpty(TextPort.Text))
            {
                Connect();
            }
            else
            {
                MessageBox.Show("IP server is null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        
        //Sign In
        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text))
            { 
                Client1.Send(Serialize($"1*{Username.Text.Length.ToString()}*{Username.Text}*{Password.Text.Length.ToString()}*{Password.Text}"));
                MessageFromServer.Text += $"Me:Login{Username.Text}%{Password.Text}{Environment.NewLine}";
            }
        }
        //Sign Up
        private void btnCreate_Click_1(object sender, EventArgs e){
            {
                if ((!string.IsNullOrEmpty(createUser.Text)) && (!string.IsNullOrEmpty(createPass.Text)) && (!string.IsNullOrEmpty(creatRePass.Text)))
                {
                    if (creatRePass.Text.ToString() == createPass.Text.ToString())
                    {
                        Client1.Send(Serialize($"2*{createUser.Text.Length.ToString()}*{createUser.Text}*{createPass.Text.Length.ToString()}*{createPass.Text}"));
                        MessageFromServer.Text += $"Me:Create:{createUser.Text}%{createPass.Text}{Environment.NewLine}";
                    }
                    else{
                        MessageBox.Show("Re_pass is invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Input is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        //Log Out
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                coinsData.Rows.Clear();
                ((Control)login).Enabled = true;
                ((Control)create).Enabled = true;
                ((Control)show).Enabled = false;
                MainControl.SelectedTab = MainControl.TabPages["login"];
                Username.Text = Password.Text = string.Empty;
                name.Text = "Hello:";
                check_LoadCombo = 0;
                updateText.Text = "Update:";
            }));
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Client1.Send(Serialize("3AllData"));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Client1.Send(Serialize($"4{SearchString.Text}@{dateCheck.Text}"));            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (CreateClient.Enabled == false)
            {
                Client1.Send(Serialize("5Disconnected"));
            }
        }
        #endregion

        #region Recieve Datta from Server
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client1.Receive(data);
                    string mess = (string)Deserialize(data);
                    checkString1(mess);
                }
            }
            catch
            {
                MessageBox.Show("Server is Disconnected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coinsData.Rows.Clear();
                ((Control)show).Enabled = false;
                MainControl.SelectedTab = MainControl.TabPages["login"];
                btnSignIn.Enabled = false;
                btnCreate.Enabled = false;
                CreateClient.Enabled = true;
                ((Control)show).Enabled = false;
                ((Control)login).Enabled = true;
                ((Control)create).Enabled = true;
            }
        }
        #endregion

        #region Load Data
        /// <summary>
        /// Tải dữ liệu cho bảng  
        /// </summary>
        private void LoadComboBox(List<Coins> data)
        {
            SearchString.Items.Clear();
            SearchString.Items.Add("All");
            List<string> stringCheck = new List<string>();
            foreach (Coins item in data)
            {
                int check = 0;
                for (int i = 0; i < stringCheck.Count; i++)
                {
                    if (stringCheck[i] == item.Currency) { check = -1; break; }
                }
                if (check == 0)
                {
                    SearchString.Items.Add(item.Currency);
                    stringCheck.Add(item.Currency);
                }
            }
            SearchString.Text = "All";
            check_LoadCombo = 1;
        }
        private void LoadDataGridView(string s)
        {
            List<Coins> data = ListCoins.Instance.Load(s);
            this.Invoke(new Action(() => {
                coinsData.Rows.Clear();
                foreach (Coins item in data)
                {
                    DataGridViewRow row = (DataGridViewRow)coinsData.Rows[0].Clone();
                    row.Cells[0].Value = item.Currency.ToString();
                    row.Cells[2].Value = item.Buy_cash.ToString();
                    row.Cells[3].Value = item.Buy_transfer.ToString();
                    row.Cells[4].Value = item.Sell.ToString();
                    row.Cells[1].Value = item.Date_time;
                    coinsData.Rows.Add(row);
                }
                if (check_LoadCombo == 0)
                {
                    LoadComboBox(data);
                    updateText.Text += data[data.Count - 1].Date_time.ToString();
                }
            }));
        }
        private void OpenTable()
        {
            this.Invoke(new Action(() => {
                ((Control)show).Enabled = true;
                ((Control)login).Enabled = false;
                ((Control)create).Enabled = false;
                MainControl.SelectedTab = MainControl.TabPages["show"];
            }));
        }
        #endregion

        #region checkString from server
        private void checkString1(string s)
        {
            if (s[0] == '1')
            {
                OpenTable(); 
                name.Text += Username.Text;
                Client1.Send(Serialize("3AllData"));
            }
            else if (s[0] == '2')
            {
                MessageBox.Show("Login unsuccessful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (s[0] == '3')
            {
                MessageBox.Show("Registration failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (s[0] == '4')
            {
                this.Invoke(new Action(() => {
                    createPass.Text = string.Empty;
                    createUser.Text = string.Empty;
                    creatRePass.Text = string.Empty;
                }));
                MessageBox.Show("Sign Up Success", "Message", MessageBoxButtons.OK);
            }
            else if (s[0] == '5')
            {
                LoadDataGridView(s);
            }
            else if (s[0] == '6')
            {
            }
        }
        #endregion

        #region change byte array to string and string to byte array
        private static byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();// stream tra ra 1 day byte
        }
        // gom manh
        private static object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        #endregion
    }
}
