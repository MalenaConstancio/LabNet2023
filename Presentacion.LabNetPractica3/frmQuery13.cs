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
    public partial class frmQuery13 : Form
    {
        NCustomer neg = new NCustomer();
        public frmQuery13()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetTotalOrdersByCustomer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetAllCustomers();
        }

        private void frmQuery13_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = neg.GetAllCustomers();
        }
    }
}
