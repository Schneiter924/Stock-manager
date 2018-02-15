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
    public partial class frmRetourPiece : Form
    {
        public frmRetourPiece()
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
            Form frmM = new frmMain();
            frmM.Show();
            this.Dispose();
        }

        private void cmdRetourPiece_Click(object sender, EventArgs e)
        {

        }

        private void frmRetourPiece_Load(object sender, EventArgs e)
        {

        }
    }
}
