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
    public partial class frmMain : Form
    {
        public frmMain()
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
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Form frmLog = new frmLogin();
            frmLog.Show();
            this.Dispose();
        }

        private void cmdInventaire_Click(object sender, EventArgs e)
        {
            Form frmInv = new frmInventaire();
            frmInv.Show();
            this.Dispose();
        }

        private void cmdEntree_Click(object sender, EventArgs e)
        {
            Form frmEnt = new frmEntree();
            frmEnt.Show();
            this.Dispose();
        }

        private void cmdSortie_Click(object sender, EventArgs e)
        {
            Form frmSor = new frmSortie();
            frmSor.Show();
            this.Dispose();
        }

        private void cmdRecherche_Click(object sender, EventArgs e)
        {
            Form frmRec = new frmReMenu();
            frmRec.Show();
            this.Dispose();
        }
    }
}
