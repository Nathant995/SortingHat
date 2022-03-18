using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SortingHat
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void btnClientClose_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[ClientEvent] Client is now closing...");
            Application.Exit();
        }
    }
}
