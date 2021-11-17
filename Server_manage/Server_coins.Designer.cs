
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TextIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIFO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateClient = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.guna2ControlBox2);
            this.panel3.Controls.Add(this.guna2ControlBox1);
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
            this.panel5.BackgroundImage = global::Server_manage.Properties.Resources.Untitled;
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
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
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
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(723, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel3;
            // 
            // TextIP
            // 
            this.TextIP.BackColor = System.Drawing.Color.Transparent;
            this.TextIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.TextIP.BorderRadius = 8;
            this.TextIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextIP.DefaultText = "192.168.56.1:9000";
            this.TextIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.DisabledState.Parent = this.TextIP;
            this.TextIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.TextIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.FocusedState.Parent = this.TextIP;
            this.TextIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TextIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.TextIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIP.HoverState.Parent = this.TextIP;
            this.TextIP.Location = new System.Drawing.Point(89, 100);
            this.TextIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextIP.Name = "TextIP";
            this.TextIP.PasswordChar = '\0';
            this.TextIP.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.TextIP.PlaceholderText = "IP/Port.......";
            this.TextIP.SelectedText = "";
            this.TextIP.SelectionStart = 17;
            this.TextIP.ShadowDecoration.Parent = this.TextIP;
            this.TextIP.Size = new System.Drawing.Size(459, 47);
            this.TextIP.TabIndex = 21;
            // 
            // textIFO
            // 
            this.textIFO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.textIFO.BorderRadius = 11;
            this.textIFO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIFO.DefaultText = "";
            this.textIFO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIFO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIFO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIFO.DisabledState.Parent = this.textIFO;
            this.textIFO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIFO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.textIFO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIFO.FocusedState.Parent = this.textIFO;
            this.textIFO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textIFO.ForeColor = System.Drawing.Color.Black;
            this.textIFO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIFO.HoverState.Parent = this.textIFO;
            this.textIFO.Location = new System.Drawing.Point(89, 165);
            this.textIFO.Multiline = true;
            this.textIFO.Name = "textIFO";
            this.textIFO.PasswordChar = '\0';
            this.textIFO.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.textIFO.PlaceholderText = "Server.....";
            this.textIFO.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textIFO.SelectedText = "";
            this.textIFO.ShadowDecoration.Parent = this.textIFO;
            this.textIFO.Size = new System.Drawing.Size(459, 324);
            this.textIFO.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Server";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.guna2TextBox1.BorderRadius = 11;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(569, 165);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(129)))), ((int)(((byte)(222)))));
            this.guna2TextBox1.PlaceholderText = "ListClient";
            this.guna2TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(182, 324);
            this.guna2TextBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(2, 109);
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
            this.label3.Location = new System.Drawing.Point(2, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Acti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(578, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "List Client";
            // 
            // CreateClient
            // 
            this.CreateClient.BorderRadius = 11;
            this.CreateClient.CheckedState.Parent = this.CreateClient;
            this.CreateClient.CustomImages.Parent = this.CreateClient;
            this.CreateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateClient.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateClient.DisabledState.Parent = this.CreateClient;
            this.CreateClient.FillColor = System.Drawing.Color.Turquoise;
            this.CreateClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateClient.ForeColor = System.Drawing.Color.White;
            this.CreateClient.HoverState.Parent = this.CreateClient;
            this.CreateClient.Location = new System.Drawing.Point(312, 505);
            this.CreateClient.Name = "CreateClient";
            this.CreateClient.ShadowDecoration.Parent = this.CreateClient;
            this.CreateClient.Size = new System.Drawing.Size(105, 43);
            this.CreateClient.TabIndex = 28;
            this.CreateClient.Text = "Open Server";
            this.CreateClient.Click += new System.EventHandler(this.CreateClient_Click);
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
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(443, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(105, 43);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(763, 570);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CreateClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIFO);
            this.Controls.Add(this.TextIP);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientTileButton CreateClient;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnClose;
    }
}

