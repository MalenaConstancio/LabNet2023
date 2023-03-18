using Entidades.LabNetPractica4;
using Negocio.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.LabNetPractica3
{
    public partial class frmQuery12 : Form
    {
        NProducts neg = new NProducts();
        public frmQuery12()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            List<Products> lstAll = neg.GetAll();
            try
            {
                Products p = neg.GetFirst(lstAll);

                List<Products> lstFirts = new List<Products>();
                lstFirts.Add(p);

                dgvProducts.DataSource = lstFirts;
            }
            catch(Exception) {
                MessageBox.Show("Error", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = neg.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuery12_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = neg.GetAll();
        }
    }
}
