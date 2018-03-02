using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager
{
    public partial class frmReMenu : Form
    {
        public frmReMenu()
        {
            InitializeComponent();
        }
        
        private void cmdMot_Click(object sender, EventArgs e)
        {
            Form frmMot = new frmReMot();
            frmMot.Show();
            this.Dispose();
        }

        private void cmdHistorique_Click(object sender, EventArgs e)
        {
            Form frmHis = new frmReHis();
            frmHis.Show();
            this.Dispose();
        }

        private void cmdHors_Click(object sender, EventArgs e)
        {
            Form frmHors = new frmReHors();
            frmHors.Show();
            this.Dispose();
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }
    }
}
