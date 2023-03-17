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
    public partial class frmQuery3 : Form
    {
        NProducts negProd = new NProducts();
        public frmQuery3()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = negProd.GetProductsWhitStockUnitPriceGreaterThan3Method().ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = negProd.GetAll();
        }

        private void frmQuery3_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = negProd.GetAll();
        }
    }
}
