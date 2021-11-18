
namespace Server_manage
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TextIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIFO = new Guna.UI2.WinForms.Guna2TextBox();
            this.listClientText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openServer = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(85)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.guna2ControlBox2);
            this.panel3.Controls.Add(this.guna2ControlBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 36);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "TCP/Server";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Server_manage.Properties.Resources.laptop;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(27, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 29);
            this.panel5.TabIndex = 7;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(683, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(40, 36);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(723, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 36);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Server";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel3;
            // 
            // TextIP
            // 
            this.TextIP.BackColor = System.Drawing.Color.Transparent;
            this.TextIP.BorderColor = System.Drawing.Color.Lime;
            this.TextIP.BorderRadius = 8;
            this.TextIP.BorderThickness = 0;
            this.TextIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextIP.DefaultText = "192.168.1.13:9000";
            this.TextIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.DisabledState.Parent = this.TextIP;
            this.TextIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.FocusedState.Parent = this.TextIP;
            this.TextIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TextIP.ForeColor = System.Drawing.Color.Black;
            this.TextIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.HoverState.Parent = this.TextIP;
            this.TextIP.Location = new System.Drawing.Point(118, 19);
            this.TextIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextIP.Name = "TextIP";
            this.TextIP.PasswordChar = '\0';
            this.TextIP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextIP.PlaceholderText = "IP/Port.......";
            this.TextIP.SelectedText = "";
            this.TextIP.ShadowDecoration.Parent = this.TextIP;
            this.TextIP.Size = new System.Drawing.Size(459, 47);
            this.TextIP.TabIndex = 21;
            // 
            // textIFO
            // 
            this.textIFO.BorderColor = System.Drawing.Color.Black;
            this.textIFO.BorderRadius = 11;
            this.textIFO.BorderThickness = 2;
            this.textIFO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIFO.DefaultText = "";
            this.textIFO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIFO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIFO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIFO.DisabledState.Parent = this.textIFO;
            this.textIFO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIFO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIFO.FocusedState.Parent = this.textIFO;
            this.textIFO.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textIFO.ForeColor = System.Drawing.Color.Black;
            this.textIFO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIFO.HoverState.Parent = this.textIFO;
            this.textIFO.Location = new System.Drawing.Point(27, 165);
            this.textIFO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textIFO.Multiline = true;
            this.textIFO.Name = "textIFO";
            this.textIFO.PasswordChar = '\0';
            this.textIFO.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textIFO.PlaceholderText = "Server.....";
            this.textIFO.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textIFO.SelectedText = "";
            this.textIFO.ShadowDecoration.Parent = this.textIFO;
            this.textIFO.Size = new System.Drawing.Size(459, 324);
            this.textIFO.TabIndex = 22;
            // 
            // listClientText
            // 
            this.listClientText.BorderColor = System.Drawing.Color.Black;
            this.listClientText.BorderRadius = 11;
            this.listClientText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listClientText.DefaultText = "";
            this.listClientText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.listClientText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.listClientText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listClientText.DisabledState.Parent = this.listClientText;
            this.listClientText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listClientText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listClientText.FocusedState.Parent = this.listClientText;
            this.listClientText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listClientText.ForeColor = System.Drawing.Color.Black;
            this.listClientText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listClientText.HoverState.Parent = this.listClientText;
            this.listClientText.Location = new System.Drawing.Point(517, 165);
            this.listClientText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listClientText.Multiline = true;
            this.listClientText.Name = "listClientText";
            this.listClientText.PasswordChar = '\0';
            this.listClientText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.listClientText.PlaceholderText = "ListClient.....";
            this.listClientText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.listClientText.SelectedText = "";
            this.listClientText.ShadowDecoration.Parent = this.listClientText;
            this.listClientText.Size = new System.Drawing.Size(234, 324);
            this.listClientText.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "IP/PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Activity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(525, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "List Client";
            // 
            // openServer
            // 
            this.openServer.BorderRadius = 11;
            this.openServer.CheckedState.Parent = this.openServer;
            this.openServer.CustomImages.Parent = this.openServer;
            this.openServer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openServer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openServer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openServer.DisabledState.Parent = this.openServer;
            this.openServer.FillColor = System.Drawing.Color.Turquoise;
            this.openServer.FillColor2 = System.Drawing.Color.Gray;
            this.openServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.openServer.ForeColor = System.Drawing.Color.White;
            this.openServer.HoverState.Parent = this.openServer;
            this.openServer.Location = new System.Drawing.Point(530, 505);
            this.openServer.Name = "openServer";
            this.openServer.ShadowDecoration.Parent = this.openServer;
            this.openServer.Size = new System.Drawing.Size(105, 43);
            this.openServer.TabIndex = 28;
            this.openServer.Text = "Open Server";
            this.openServer.Click += new System.EventHandler(this.CreateClient_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 11;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.CadetBlue;
            this.btnClose.FillColor2 = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(646, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(105, 43);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close Server";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.TextIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 80);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Server_manage.Properties.Resources.dai_hoc_khoa_hoc_tu_nhien_dhqg_hcm;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(27, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 55);
            this.panel2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(217)))));
            this.label6.Location = new System.Drawing.Point(86, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "HCMUS";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(763, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.openServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listClientText);
            this.Controls.Add(this.textIFO);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TextIP;
        private Guna.UI2.WinForms.Guna2TextBox textIFO;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox listClientText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientTileButton openServer;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

