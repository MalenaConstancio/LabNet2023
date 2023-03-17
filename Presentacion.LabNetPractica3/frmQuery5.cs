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
    public partial class frmQuery5 : Form
    {
        NProducts negPRod = new NProducts();
        public frmQuery5()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = negPRod.GetFirstOrNull();
        }

        private void frmQuery5_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = negPRod.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = negPRod.GetAll();
        }
    }
}
