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
    public partial class frmQuery1 : Form
    {
        NCustomer negCust = new NCustomer();
        public frmQuery1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idCustomer = txtIdCustomer.Text;
            try
            {
                List<Customers> selected = negCust.GetCustomerSintax(idCustomer).ToList();
                if (selected.Count != 0)
                {
                    dgvCustomer.DataSource = selected;
                    txtIdCustomer.Text = " ";
                }
                else {
                    MessageBox.Show("No existe el Id ingresado", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdCustomer.Text = " ";
                }
                
            }
            catch (Exception) {
                MessageBox.Show("No existe el Id ingresado", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmQuery1_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }

    }
}
