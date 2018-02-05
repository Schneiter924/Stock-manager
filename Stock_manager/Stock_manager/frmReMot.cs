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
    public partial class frmReMot : Form
    {
        public frmReMot()
        {
            InitializeComponent();
        }

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmReMenu();
            frmMenu.Show();
            this.Dispose();
        }
    }
}
