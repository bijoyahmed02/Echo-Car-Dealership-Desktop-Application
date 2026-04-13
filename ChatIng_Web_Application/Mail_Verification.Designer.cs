namespace ChatIng_Web_Application
{
    partial class Mail_Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail_Verification));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_confirm = new System.Windows.Forms.Button();
            this.Mail_sent = new System.Windows.Forms.Button();
            this.Timmer = new System.Windows.Forms.Timer(this.components);
            this.verification_Main_Maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtconfirm);
            this.panel1.Controls.Add(this.txtGmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.t_confirm);
            this.panel1.Controls.Add(this.Mail_sent);
            this.panel1.Location = new System.Drawing.Point(166, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 304);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Verification Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Re-Type Mail";
            // 
            // txtconfirm
            // 
            this.txtconfirm.AutoRoundedCorners = true;
            this.txtconfirm.BackColor = System.Drawing.Color.Transparent;
            this.txtconfirm.BorderRadius = 17;
            this.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirm.DefaultText = "";
            this.txtconfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtconfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirm.Location = new System.Drawing.Point(28, 200);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '\0';
            this.txtconfirm.PlaceholderText = "";
            this.txtconfirm.SelectedText = "";
            this.txtconfirm.Size = new System.Drawing.Size(254, 36);
            this.txtconfirm.TabIndex = 10;
            // 
            // txtGmail
            // 
            this.txtGmail.AutoRoundedCorners = true;
            this.txtGmail.BackColor = System.Drawing.Color.Transparent;
            this.txtGmail.BorderRadius = 17;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.DefaultText = "";
            this.txtGmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGmail.Location = new System.Drawing.Point(28, 115);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.PasswordChar = '\0';
            this.txtGmail.PlaceholderText = "";
            this.txtGmail.SelectedText = "";
            this.txtGmail.Size = new System.Drawing.Size(254, 36);
            this.txtGmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // username
            // 
            this.username.AutoRoundedCorners = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderRadius = 17;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(28, 40);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(254, 36);
            this.username.TabIndex = 7;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // t_confirm
            // 
            this.t_confirm.Location = new System.Drawing.Point(225, 241);
            this.t_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_confirm.Name = "t_confirm";
            this.t_confirm.Size = new System.Drawing.Size(56, 19);
            this.t_confirm.TabIndex = 5;
            this.t_confirm.Text = "Confirm";
            this.t_confirm.UseVisualStyleBackColor = true;
            this.t_confirm.Click += new System.EventHandler(this.t_confirm_Click);
            // 
            // Mail_sent
            // 
            this.Mail_sent.Location = new System.Drawing.Point(226, 156);
            this.Mail_sent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mail_sent.Name = "Mail_sent";
            this.Mail_sent.Size = new System.Drawing.Size(56, 19);
            this.Mail_sent.TabIndex = 2;
            this.Mail_sent.Text = "Sent";
            this.Mail_sent.UseVisualStyleBackColor = true;
            this.Mail_sent.Click += new System.EventHandler(this.Mail_sent_Click);
            // 
            // Timmer
            // 
            this.Timmer.Enabled = true;
            this.Timmer.Interval = 9999;
            this.Timmer.Tick += new System.EventHandler(this.Timmer_Tick_1);
            // 
            // verification_Main_Maximize
            // 
            this.verification_Main_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verification_Main_Maximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.verification_Main_Maximize.IconColor = System.Drawing.Color.White;
            this.verification_Main_Maximize.Location = new System.Drawing.Point(614, 11);
            this.verification_Main_Maximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.verification_Main_Maximize.Name = "verification_Main_Maximize";
            this.verification_Main_Maximize.Size = new System.Drawing.Size(34, 24);
            this.verification_Main_Maximize.TabIndex = 1;
            this.verification_Main_Maximize.Click += new System.EventHandler(this.verification_Main_Maximize_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(562, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // Mail_Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 457);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.verification_Main_Maximize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mail_Verification";
            this.Text = "Mail_Verification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button t_confirm;
        private System.Windows.Forms.Button Mail_sent;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtconfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtGmail;
        private System.Windows.Forms.Timer Timmer;
        private Guna.UI2.WinForms.Guna2ControlBox verification_Main_Maximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}