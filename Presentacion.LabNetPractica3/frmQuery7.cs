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
    public partial class frmQuery7 : Form
    {
        NCustomer neg = new NCustomer();
        public frmQuery7()
        {
            InitializeComponent();
        }

        private void frmQuery7_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetAllCustomers();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetCustomersWARegionAndOrdersAfter1997();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetAllCustomers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
