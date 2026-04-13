using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Guna.UI2.WinForms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace ChatIng_Web_Application
{
    public partial class Mail_Verification : Form
    {
        private Random random = new Random();
        public Mail_Verification()
        {
            InitializeComponent();

        }
        
        int vCode;
        private void Mail_sent_Click(object sender, EventArgs e)
        {
            Timmer.Stop();
            string to, from, pass, mail;
            to = txtGmail.Text;
            from = "rahulxiaozion@gmail.com";
            mail =vCode.ToString();
            pass = "ltzj hqwz ibuj dkmp";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From=new MailAddress(from);
            string verificationCode = mail;
            mail = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Verify Your Email - Echo Talk</title>
    <style>
        body {{
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 20px;
            color: #333333;
            background-color: #e0f7fa; /* Light blue background */
        }}
        .container {{
            max-width: 600px;
            margin: 0 auto;
            background-color: rgba(255, 255, 255, 0.9);
            border-radius: 12px;
            overflow: hidden;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
            padding: 20px;
        }}
        .header {{
            background: linear-gradient(90deg, #ff5722, #ff9800);
            padding: 20px;
            text-align: center;
            border-bottom: 2px solid #ff5722;
        }}
        .header img {{
            max-width: 150px;
        }}
        .body {{
            padding: 30px;
           background-color: #FFF5E4;
        }}
        .body h2 {{
            color: #ff5722;
            text-shadow: 0 2px 4px rgba(0, 0, 0, 0.3);
        }}
        .body p {{
            color: #333333;
        }}
        .button {{
            background-color: #ff5722; /* Button color */
            color: #ffffff;
            padding: 15px 30px;
            text-decoration: none;
            border-radius: 5px;
            font-size: 16px;
            display: inline-block;
            border: 2px solid #ff5722;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
            transition: all 0.3s ease;
        }}
        .button:hover {{
            background-color: #ffffff;
            color: #ff5722;
        }}
        .footer {{
            background: #ff9800;
            padding: 20px;
            text-align: center;
            border-top: 2px solid #ff5722;
        }}
        .footer p {{
            color: #ffffff;
            font-size: 14px;
            margin: 0;
        }}
        .footer img {{
            width: 24px;
            vertical-align: middle;
            margin: 0 5px;
        }}
        .footer p.small {{
            color: #ffffff;
            font-size: 12px;
            margin-top: 10px;
        }}
        .code-section {{
            text-align: center;
            margin-top: 20px;
        }}
        .code-box {{
            background-color: #ffffff;
            color: #333333;
            border: 1px solid #ff5722;
            border-radius: 5px;
            padding: 15px;
            display: inline-block;
            font-size: 16px;
            font-weight: bold;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <!-- Header with Logo -->
        <div class=""header"">
            <img src="""" alt=""Echo Talk"">
        </div>

        <!-- Body Content -->
        <div class=""body"">
            <h2>Welcome to Echo Talk!</h2>
            <p>Hi <strong>User</strong>,</p>
            <p>Thank you for signing up with Echo Talk! To get started, please use the verification code below:</p>
            <p style=""text-align: center; font-size: 24px; font-weight: bold; color: #ff5722;"">{verificationCode}</p>
            <p style=""text-align: center; color: #333333;"">If you did not create an account with Echo Talk, please ignore this email.</p>
        </div>

        <!-- Footer -->
        <div class=""footer"">
            <p>Thank you for joining us at Echo Talk!</p>
            <p>
                <a href=""https://github.com/rahulxiao"" target=""_blank"">
                    <img src=""https://img.icons8.com/color/48/000000/github.png"" alt=""GitHub"">
                </a>
                <a href=""https://www.facebook.com/rahulxiao/"" target=""_blank"">
                    <img src=""https://img.icons8.com/color/48/000000/facebook.png"" alt=""Facebook"">
                </a>
                <a href=""https://www.instagram.com/rahulxiao/"" target=""_blank"">
                    <img src=""https://img.icons8.com/color/48/000000/instagram-new.png"" alt=""Instagram"">
                </a>
            </p>
            <p class=""small"">This is an automated message; please do not reply.</p>
        </div>
    </div>
</body>
</html>
";
            message.IsBodyHtml = true;
            message.Body = mail;
            message.Subject = "Verifivation Code For EchoTalk";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Verifition Code sent successful!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                t_confirm.Enabled = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timmer_Tick(object sender, EventArgs e)
        {
            int minCode = 100000; 
            int maxCode = 999999; 
            vCode = random.Next(minCode, maxCode + 1);
        }
        private void t_confirm_Click(object sender, EventArgs e)
        {
            if (txtconfirm.Text == vCode.ToString() && !string.IsNullOrEmpty(username.Text))
            {
                Main_Page main = new Main_Page();
                main.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Timmer_Tick_1(object sender, EventArgs e)
        {
            int minCode = 100000;
            int maxCode = 999999;
            vCode = random.Next(minCode, maxCode + 1);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void verification_Main_Maximize_Click(object sender, EventArgs e)
        {
            
        }
    }
}
