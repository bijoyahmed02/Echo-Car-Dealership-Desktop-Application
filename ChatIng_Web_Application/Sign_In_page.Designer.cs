namespace ChatIng_Web_Application
{
    partial class Sign_In_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In_Page));
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.User_Login_Planel = new System.Windows.Forms.Panel();
            this.adminn = new Guna.UI2.WinForms.Guna2Button();
            this.Sign_IN = new Guna.UI2.WinForms.Guna2Button();
            this.Password_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.userID_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Google = new System.Windows.Forms.PictureBox();
            this.EchoChat = new System.Windows.Forms.Label();
            this.Forget_Pass = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.User_Login_Planel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(53, 65);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(101, 23);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(53, 140);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 23);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // User_Login_Planel
            // 
            this.User_Login_Planel.BackColor = System.Drawing.Color.Transparent;
            this.User_Login_Planel.Controls.Add(this.adminn);
            this.User_Login_Planel.Controls.Add(this.Sign_IN);
            this.User_Login_Planel.Controls.Add(this.Password_Box);
            this.User_Login_Planel.Controls.Add(this.userID_Box);
            this.User_Login_Planel.Controls.Add(this.label3);
            this.User_Login_Planel.Controls.Add(this.pictureBox3);
            this.User_Login_Planel.Controls.Add(this.label2);
            this.User_Login_Planel.Controls.Add(this.pictureBox2);
            this.User_Login_Planel.Controls.Add(this.pictureBox1);
            this.User_Login_Planel.Controls.Add(this.Google);
            this.User_Login_Planel.Controls.Add(this.EchoChat);
            this.User_Login_Planel.Controls.Add(this.Forget_Pass);
            this.User_Login_Planel.Controls.Add(this.label1);
            this.User_Login_Planel.Controls.Add(this.UserName);
            this.User_Login_Planel.Controls.Add(this.Password);
            this.User_Login_Planel.Location = new System.Drawing.Point(453, 140);
            this.User_Login_Planel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_Login_Planel.Name = "User_Login_Planel";
            this.User_Login_Planel.Size = new System.Drawing.Size(361, 434);
            this.User_Login_Planel.TabIndex = 6;
            this.User_Login_Planel.Paint += new System.Windows.Forms.PaintEventHandler(this.User_Login_Planel_Paint);
            // 
            // adminn
            // 
            this.adminn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.adminn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminn.ForeColor = System.Drawing.Color.White;
            this.adminn.Location = new System.Drawing.Point(236, 387);
            this.adminn.Name = "adminn";
            this.adminn.Size = new System.Drawing.Size(109, 31);
            this.adminn.TabIndex = 9;
            this.adminn.Text = "Admin";
            this.adminn.Click += new System.EventHandler(this.adminn_Click);
            // 
            // Sign_IN
            // 
            this.Sign_IN.AutoRoundedCorners = true;
            this.Sign_IN.BorderRadius = 22;
            this.Sign_IN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sign_IN.ForeColor = System.Drawing.Color.White;
            this.Sign_IN.Location = new System.Drawing.Point(57, 238);
            this.Sign_IN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sign_IN.Name = "Sign_IN";
            this.Sign_IN.Size = new System.Drawing.Size(231, 46);
            this.Sign_IN.TabIndex = 18;
            this.Sign_IN.Text = "Sign In";
            this.Sign_IN.Click += new System.EventHandler(this.Sign_IN_Click_1);
            // 
            // Password_Box
            // 
            this.Password_Box.AutoRoundedCorners = true;
            this.Password_Box.BorderRadius = 22;
            this.Password_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Box.DefaultText = "";
            this.Password_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Box.Location = new System.Drawing.Point(57, 166);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.PlaceholderText = "password";
            this.Password_Box.SelectedText = "";
            this.Password_Box.Size = new System.Drawing.Size(231, 46);
            this.Password_Box.TabIndex = 17;
            // 
            // userID_Box
            // 
            this.userID_Box.AutoRoundedCorners = true;
            this.userID_Box.BorderRadius = 22;
            this.userID_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userID_Box.DefaultText = "";
            this.userID_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userID_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userID_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userID_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userID_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userID_Box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userID_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userID_Box.Location = new System.Drawing.Point(57, 91);
            this.userID_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userID_Box.Name = "userID_Box";
            this.userID_Box.PasswordChar = '\0';
            this.userID_Box.PlaceholderText = "username";
            this.userID_Box.SelectedText = "";
            this.userID_Box.Size = new System.Drawing.Size(231, 46);
            this.userID_Box.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Facebook";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(124, 332);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Google";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 153);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Google
            // 
            this.Google.Image = ((System.Drawing.Image)(resources.GetObject("Google.Image")));
            this.Google.Location = new System.Drawing.Point(32, 332);
            this.Google.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(25, 25);
            this.Google.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Google.TabIndex = 10;
            this.Google.TabStop = false;
            // 
            // EchoChat
            // 
            this.EchoChat.AutoSize = true;
            this.EchoChat.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EchoChat.Location = new System.Drawing.Point(145, 15);
            this.EchoChat.Name = "EchoChat";
            this.EchoChat.Size = new System.Drawing.Size(101, 23);
            this.EchoChat.TabIndex = 8;
            this.EchoChat.Text = "Echo Chat";
            this.EchoChat.Click += new System.EventHandler(this.label2_Click);
            // 
            // Forget_Pass
            // 
            this.Forget_Pass.AutoSize = true;
            this.Forget_Pass.Location = new System.Drawing.Point(125, 215);
            this.Forget_Pass.Name = "Forget_Pass";
            this.Forget_Pass.Size = new System.Drawing.Size(114, 17);
            this.Forget_Pass.TabIndex = 7;
            this.Forget_Pass.TabStop = true;
            this.Forget_Pass.Text = "Forget Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "--Or Sign In With--";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.PaleGreen;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1195, 12);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 7;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1132, 12);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // back
            // 
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(-2, -3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(180, 45);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Sign_In_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 711);
            this.ControlBox = false;
            this.Controls.Add(this.back);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.User_Login_Planel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign_In_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.User_Login_Planel.ResumeLayout(false);
            this.User_Login_Planel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Google)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Panel User_Login_Planel;
        private System.Windows.Forms.LinkLabel Forget_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EchoChat;
        private System.Windows.Forms.PictureBox Google;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox Password_Box;
        private Guna.UI2.WinForms.Guna2TextBox userID_Box;
        private Guna.UI2.WinForms.Guna2Button Sign_IN;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button adminn;
        private Guna.UI2.WinForms.Guna2Button back;
    }
}

