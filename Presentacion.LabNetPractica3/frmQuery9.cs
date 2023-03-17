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
    public partial class frmQuery9 : Form
    {
        NProducts neg = new NProducts();
        public frmQuery9()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = neg.GetOrderProductsList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = neg.GetAll();
        }

        private void frmQuery9_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = neg.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
