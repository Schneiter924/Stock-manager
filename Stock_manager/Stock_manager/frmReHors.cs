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
    public partial class frmReHors : Form
    {
        public frmReHors()
        {
            InitializeComponent();
        }
        
        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmReMenu();
            frmMenu.Show();
            this.Dispose();
        }

        private void frmReHors_Load(object sender, EventArgs e)
        {
            Connection_mySQL smsql = new Connection_mySQL();

            List<Location> lstLocations = smsql.ProduitHorsDelais();

            foreach (Location location in lstLocations)
            {
                lstRecherche.Items.Add(location.DescriptionLocation());
            }
        }

        private void frmReHors_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmMenu = new frmReMenu();
            frmMenu.Show();
            this.Dispose();
        }
    }
}
