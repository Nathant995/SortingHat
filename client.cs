using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Threading;
using System.Diagnostics;

namespace Project_SortingHat
{
    public partial class frmClient : Form
    {
        int currenttime = 0;
        int introtime = 0;
        public string mode = "play";
        public string PlayingPosition, Duration;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public frmClient()
        {
            InitializeComponent();

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void client_Load(object sender, EventArgs e)
        {
            wmpSortingHat.Ctlcontrols.stop();

            wplayer.URL = "C:/Users/Natha/Source/Repos/SortingHat/data/Audio/ambient.mp3";
            wplayer.controls.play();
            wmp1.Visible = true;
            wmp1.Show();
            startWatch();




        }

        public void startWatch()
        {
            clock.Enabled = true;
            clock.Start();
        }
        private void btnClientClose_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[ClientEvent] Client is now closing...");
            Application.Exit();
        }

        private void btnClientStartSorting_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[Client Actions] Loading Sorting Hat Logic...");
            loadSortingHatProc();
        }

        private void clock_Tick(object sender, EventArgs e)
        {


            currenttime++;
            if (currenttime >= 7)
            {
                wmp1.Hide();
                wmp1.Visible = false;
            }





        }

        private void loadSortingHatProc()
        {
            Console.WriteLine("[Client Actions] Loading Sorting House Processes");
            pnlSortingHat.Show();
            pnlSortingHat.Visible = true;
            panel1.Visible = false;
            panel1.Hide();
            StartSortingHatIntro();

        }
        public void startIntroWatch()
        {
            tmrSortingHouse.Enabled = true;
            tmrSortingHouse.Start();
        }

        private void tmrSortingHouse_Tick(object sender, EventArgs e)
        {
            introtime++;
            if (introtime >= 16)
            {
              
                wmpSortingHat.Hide();
                wmpSortingHat.Visible = false;
            }
            if (wmpSortingHat.Visible == false)
            {
                Console.WriteLine("[Client Actions] Stopping Intro Video");
                tmrSortingHouse.Stop();
                pnlUI.Visible = true;
                pnlUI.Enabled = true;
                pnlUI.Show();
            }
        }

        void StartSortingHatIntro()
        {
            wplayer.controls.stop();
            wmpSortingHat.Ctlcontrols.play();
            startIntroWatch();
        }
    }
}