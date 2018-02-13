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
    public partial class frmSortie : Form
    {
        public frmSortie()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMain();
            frmMenu.Show();
            this.Dispose();
        }

        private void cmdAjout_Click(object sender, EventArgs e)
        {

        }

        private void frmSortie_Load(object sender, EventArgs e)
        {
            DateTime Aujourdhui = DateTime.Today;
            DateTime trenteJours = Aujourdhui.AddDays(30);
            txtDateRetour.Text = trenteJours.ToString("dd-MM-yyyy");
        }
    }
}
