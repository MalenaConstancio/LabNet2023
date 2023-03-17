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
    public partial class frmQuery6 : Form
    {
        NCustomer negCust = new NCustomer();
        public frmQuery6()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuery6_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = negCust.GetAllCustomers();
            btnMayuscula.Visible = false;
            btnMinuscula.Visible = false;
        }

        bool activado = false;
        private void btnProbar_Click(object sender, EventArgs e)
        {
            activado = true;
            btnMayuscula.Visible = true;
            btnMinuscula.Visible = true;
            dgvCustomers.DataSource = negCust.GetCustomersNamesSintax();
        }

        private void btnMayuscula_Click(object sender, EventArgs e)
        {
           
           dgvCustomers.DataSource = negCust.GetCustomersNamesMayusMethod();

        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = negCust.GetCustomersNamesLowerMethod();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = negCust.GetAllCustomers();
            activado = false;
            btnMayuscula.Visible = false;
            btnMinuscula.Visible = false;
        }
    }
}
