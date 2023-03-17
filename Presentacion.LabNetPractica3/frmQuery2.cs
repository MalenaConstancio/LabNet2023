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
    public partial class frmQuery2 : Form
    {
        NProducts negProd = new NProducts();
        public frmQuery2()
        {
            InitializeComponent();
        }

        private void frmQuery2_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = negProd.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = negProd.GetProductsWhitoutStockMethod().ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource= negProd.GetAll();
        }
    }
}
