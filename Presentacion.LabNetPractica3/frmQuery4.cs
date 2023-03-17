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
    public partial class frmQuery4 : Form
    {
        NCustomer negCust = new NCustomer();
        public frmQuery4()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetCustomersRegionWAMethod().ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuery4_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }
    }
}
