using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MaterialUI FTerm

namespace RobuxIsFree
{
    public partial class FTerm : Form
    {
        public FTerm()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = !timer1.Enabled;

        }

        private void FTerm_Load(object sender, EventArgs e)
        {

        }

        private void FTerm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void FTerm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        int a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                ftermm.AppendText("/home/glemu/: ./script.py -uinf uinf.txt");
            }
            else if (a == 2)
            {
                ftermm.AppendText("\nLoading R$ hack script...(1/2)");
            }
            else if (a == 3)
            {
                ftermm.AppendText("\nR$ hacker script v1.0 by teppyboy.");
            }
            else if (a == 5)
            {
                ftermm.AppendText("\nLoading R$ hack script...(2/2)");
            }
            else if (a == 9)
            {
                ftermm.AppendText("\nSuccessfully loaded R$ Hacker.");
                ftermm.AppendText("\nUser hack information: Privated");
                ftermm.AppendText("\nConnecting to ROBLOX...");
            }
            else if (a == 14)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nNetwork default protocol access failed! Try switching to Pr0Xy...");
            }
            else if (a == 19)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nSwitched to Pr0Xy mode.");
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 1)");
            }
            else if (a == 24)
            {
                ftermm.AppendText("\nPr0Xy mode failed to start(Invaild Proxy+Socks: 143.22.45.89:1273)");
                ftermm.AppendText("\nSwitching to ForceCNT+");
            }
            else if (a == 29)
            {
                ftermm.AppendText("\nSwitched to ForceCNT+ mode.");
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 2)");
            }
            else if (a == 34)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT+ mode failed. Error 1337(null)");
                ftermm.AppendText("\nSwitching to ForceCNT++");
            }
            else if (a == 39)
            {
                ftermm.AppendText("\nSwitched to ForceCNT++ mode.");
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 3)");
            }
            else if (a == 44)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nRetrying...");
            }
            else if (a == 49)
            {
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 4)");
            }
            else if (a == 54)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nRetrying...");
            }
            else if (a == 59)
            {
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 5)");
            }
            else if (a == 64)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nRetrying...");

            }
            else if (a == 69)
            {
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 6)");
            }
            else if (a == 74)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nRetrying...");
            }
            else if (a == 79)
            {
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 7)");
            }
            else if (a == 84)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nRetrying...");
            }
            else if (a == 89)
            {
                ftermm.AppendText("\nConnecting to ROBLOX... (Retry 8)");
            }
            else if (a == 98)
            {
                ftermm.AppendText("\nConnecting to ROBLOX failed.");
                ftermm.AppendText("\nForceCNT++ mode failed. Error 1280: Invaild token authencation for 69.172.201.47(This web blocked us?)");
                ftermm.AppendText("\nConnect to ROBLOX failed. Exititng Terminal in 1 second...");
            }
            else if (a == 99)
            {
                this.Close();
            }
        }
    }
}
