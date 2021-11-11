
namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.RePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ConnectAgain = new Guna.UI2.WinForms.Guna2Button();
            this.Message = new System.Windows.Forms.Label();
            this.MessageFromServer = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateClient = new Guna.UI2.WinForms.Guna2Button();
            this.Port = new System.Windows.Forms.Label();
            this.TextPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignIn = new Guna.UI2.WinForms.Guna2Button();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainControl.Controls.Add(this.tabPage1);
            this.MainControl.Controls.Add(this.tabPage2);
            this.MainControl.ItemSize = new System.Drawing.Size(180, 40);
            this.MainControl.Location = new System.Drawing.Point(0, -1);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(737, 610);
            this.MainControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.MainControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.MainControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.MainControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.MainControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.MainControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.MainControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.MainControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.MainControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.MainControl.TabIndex = 0;
            this.MainControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.CreateAccount);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.RePass);
            this.panel1.Controls.Add(this.NewPass);
            this.panel1.Controls.Add(this.NewUser);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 606);
            this.panel1.TabIndex = 0;
            // 
            // NewUser
            // 
            this.NewUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewUser.DefaultText = "";
            this.NewUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUser.DisabledState.Parent = this.NewUser;
            this.NewUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUser.FocusedState.Parent = this.NewUser;
            this.NewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUser.HoverState.Parent = this.NewUser;
            this.NewUser.Location = new System.Drawing.Point(202, 111);
            this.NewUser.Name = "NewUser";
            this.NewUser.PasswordChar = '\0';
            this.NewUser.PlaceholderText = "";
            this.NewUser.SelectedText = "";
            this.NewUser.ShadowDecoration.Parent = this.NewUser;
            this.NewUser.Size = new System.Drawing.Size(200, 36);
            this.NewUser.TabIndex = 0;
            // 
            // NewPass
            // 
            this.NewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPass.DefaultText = "";
            this.NewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPass.DisabledState.Parent = this.NewPass;
            this.NewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPass.FocusedState.Parent = this.NewPass;
            this.NewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPass.HoverState.Parent = this.NewPass;
            this.NewPass.Location = new System.Drawing.Point(202, 221);
            this.NewPass.Name = "NewPass";
            this.NewPass.PasswordChar = '\0';
            this.NewPass.PlaceholderText = "";
            this.NewPass.SelectedText = "";
            this.NewPass.ShadowDecoration.Parent = this.NewPass;
            this.NewPass.Size = new System.Drawing.Size(200, 36);
            this.NewPass.TabIndex = 1;
            // 
            // RePass
            // 
            this.RePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePass.DefaultText = "";
            this.RePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePass.DisabledState.Parent = this.RePass;
            this.RePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePass.FocusedState.Parent = this.RePass;
            this.RePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePass.HoverState.Parent = this.RePass;
            this.RePass.Location = new System.Drawing.Point(202, 324);
            this.RePass.Name = "RePass";
            this.RePass.PasswordChar = '\0';
            this.RePass.PlaceholderText = "";
            this.RePass.SelectedText = "";
            this.RePass.ShadowDecoration.Parent = this.RePass;
            this.RePass.Size = new System.Drawing.Size(200, 36);
            this.RePass.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Re Password";
            // 
            // CreateAccount
            // 
            this.CreateAccount.AutoRoundedCorners = true;
            this.CreateAccount.BorderRadius = 22;
            this.CreateAccount.CheckedState.Parent = this.CreateAccount;
            this.CreateAccount.CustomImages.Parent = this.CreateAccount;
            this.CreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccount.DisabledState.Parent = this.CreateAccount;
            this.CreateAccount.FillColor = System.Drawing.Color.Magenta;
            this.CreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccount.ForeColor = System.Drawing.Color.White;
            this.CreateAccount.HoverState.Parent = this.CreateAccount;
            this.CreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("CreateAccount.Image")));
            this.CreateAccount.Location = new System.Drawing.Point(346, 407);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.ShadowDecoration.Parent = this.CreateAccount;
            this.CreateAccount.Size = new System.Drawing.Size(56, 46);
            this.CreateAccount.TabIndex = 6;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(326, 459);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Create Account";
            // 
            // ConnectAgain
            // 
            this.ConnectAgain.AutoRoundedCorners = true;
            this.ConnectAgain.BorderRadius = 21;
            this.ConnectAgain.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.ConnectAgain.CheckedState.Parent = this.ConnectAgain;
            this.ConnectAgain.CustomImages.Parent = this.ConnectAgain;
            this.ConnectAgain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConnectAgain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConnectAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConnectAgain.DisabledState.Parent = this.ConnectAgain;
            this.ConnectAgain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectAgain.ForeColor = System.Drawing.Color.White;
            this.ConnectAgain.HoverState.Parent = this.ConnectAgain;
            this.ConnectAgain.Image = ((System.Drawing.Image)(resources.GetObject("ConnectAgain.Image")));
            this.ConnectAgain.Location = new System.Drawing.Point(951, 214);
            this.ConnectAgain.Name = "ConnectAgain";
            this.ConnectAgain.ShadowDecoration.Parent = this.ConnectAgain;
            this.ConnectAgain.Size = new System.Drawing.Size(46, 45);
            this.ConnectAgain.TabIndex = 15;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(771, 335);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(147, 17);
            this.Message.TabIndex = 14;
            this.Message.Text = "Message From Server";
            // 
            // MessageFromServer
            // 
            this.MessageFromServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageFromServer.DefaultText = "";
            this.MessageFromServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageFromServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageFromServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageFromServer.DisabledState.Parent = this.MessageFromServer;
            this.MessageFromServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageFromServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageFromServer.FocusedState.Parent = this.MessageFromServer;
            this.MessageFromServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessageFromServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageFromServer.HoverState.Parent = this.MessageFromServer;
            this.MessageFromServer.Location = new System.Drawing.Point(771, 359);
            this.MessageFromServer.Name = "MessageFromServer";
            this.MessageFromServer.PasswordChar = '\0';
            this.MessageFromServer.PlaceholderText = "";
            this.MessageFromServer.SelectedText = "";
            this.MessageFromServer.ShadowDecoration.Parent = this.MessageFromServer;
            this.MessageFromServer.Size = new System.Drawing.Size(269, 202);
            this.MessageFromServer.TabIndex = 13;
            // 
            // CreateClient
            // 
            this.CreateClient.AutoRoundedCorners = true;
            this.CreateClient.BorderRadius = 21;
            this.CreateClient.CheckedState.Parent = this.CreateClient;
            this.CreateClient.CustomImages.Parent = this.CreateClient;
            this.CreateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateClient.DisabledState.Parent = this.CreateClient;
            this.CreateClient.FillColor = System.Drawing.Color.Green;
            this.CreateClient.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CreateClient.ForeColor = System.Drawing.Color.Black;
            this.CreateClient.HoverState.Parent = this.CreateClient;
            this.CreateClient.Location = new System.Drawing.Point(775, 214);
            this.CreateClient.Name = "CreateClient";
            this.CreateClient.PressedColor = System.Drawing.Color.Maroon;
            this.CreateClient.ShadowDecoration.Parent = this.CreateClient;
            this.CreateClient.Size = new System.Drawing.Size(153, 45);
            this.CreateClient.TabIndex = 12;
            this.CreateClient.Text = "Create New Client";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(774, 117);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 11;
            this.Port.Text = "Port";
            // 
            // TextPort
            // 
            this.TextPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPort.DefaultText = "";
            this.TextPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPort.DisabledState.Parent = this.TextPort;
            this.TextPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPort.FocusedState.Parent = this.TextPort;
            this.TextPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPort.HoverState.Parent = this.TextPort;
            this.TextPort.Location = new System.Drawing.Point(774, 140);
            this.TextPort.Name = "TextPort";
            this.TextPort.PasswordChar = '\0';
            this.TextPort.PlaceholderText = "";
            this.TextPort.SelectedText = "";
            this.TextPort.ShadowDecoration.Parent = this.TextPort;
            this.TextPort.Size = new System.Drawing.Size(200, 36);
            this.TextPort.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP";
            // 
            // TextIP
            // 
            this.TextIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextIP.DefaultText = "";
            this.TextIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.DisabledState.Parent = this.TextIP;
            this.TextIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.FocusedState.Parent = this.TextIP;
            this.TextIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.HoverState.Parent = this.TextIP;
            this.TextIP.Location = new System.Drawing.Point(771, 32);
            this.TextIP.Name = "TextIP";
            this.TextIP.PasswordChar = '\0';
            this.TextIP.PlaceholderText = "";
            this.TextIP.SelectedText = "";
            this.TextIP.ShadowDecoration.Parent = this.TextIP;
            this.TextIP.Size = new System.Drawing.Size(200, 36);
            this.TextIP.TabIndex = 8;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.label3);
            this.LoginPage.Controls.Add(this.label2);
            this.LoginPage.Controls.Add(this.Username);
            this.LoginPage.Controls.Add(this.SignIn);
            this.LoginPage.Controls.Add(this.Password);
            this.LoginPage.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginPage.Location = new System.Drawing.Point(7, -4);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(542, 606);
            this.LoginPage.TabIndex = 3;
            this.LoginPage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "Password";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.Parent = this.Password;
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.FocusedState.Parent = this.Password;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.HoverState.Parent = this.Password;
            this.Password.Location = new System.Drawing.Point(162, 171);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.SelectionStart = 8;
            this.Password.ShadowDecoration.Parent = this.Password;
            this.Password.Size = new System.Drawing.Size(200, 36);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // SignIn
            // 
            this.SignIn.AutoRoundedCorners = true;
            this.SignIn.BorderRadius = 15;
            this.SignIn.CheckedState.Parent = this.SignIn;
            this.SignIn.CustomImages.Parent = this.SignIn;
            this.SignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignIn.DisabledState.Parent = this.SignIn;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.HoverState.Parent = this.SignIn;
            this.SignIn.Location = new System.Drawing.Point(277, 324);
            this.SignIn.Name = "SignIn";
            this.SignIn.ShadowDecoration.Parent = this.SignIn;
            this.SignIn.Size = new System.Drawing.Size(85, 33);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Sign In";
            this.SignIn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "Username";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.Parent = this.Username;
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.FocusedState.Parent = this.Username;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.HoverState.Parent = this.Username;
            this.Username.Location = new System.Drawing.Point(162, 84);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderText = "";
            this.Username.SelectedText = "";
            this.Username.SelectionStart = 8;
            this.Username.ShadowDecoration.Parent = this.Username;
            this.Username.Size = new System.Drawing.Size(200, 36);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 591);
            this.panel2.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.LoginPage);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 606);
            this.Controls.Add(this.ConnectAgain);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.MessageFromServer);
            this.Controls.Add(this.CreateClient);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextIP);
            this.Controls.Add(this.MainControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl MainControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button CreateAccount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox RePass;
        private Guna.UI2.WinForms.Guna2TextBox NewPass;
        private Guna.UI2.WinForms.Guna2TextBox NewUser;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LoginPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2Button SignIn;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2Button ConnectAgain;
        private System.Windows.Forms.Label Message;
        private Guna.UI2.WinForms.Guna2TextBox MessageFromServer;
        private Guna.UI2.WinForms.Guna2Button CreateClient;
        private System.Windows.Forms.Label Port;
        private Guna.UI2.WinForms.Guna2TextBox TextPort;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextIP;
    }
}

