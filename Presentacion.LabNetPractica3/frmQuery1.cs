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
            List<Customers> selected = negCust.GetCustomerSintax(idCustomer).ToList();
            dgvCustomer.DataSource = selected;
            txtIdCustomer.Text = " ";

        }

        private void frmQuery1_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = negCust.GetAllCustomers();
        }

        //private void txtIdCustomer_TextChanged(object sender, EventArgs e)
        //{
        //    List<Customers> lstCustomers = new List<Customers>();
        //    lstCustomers = negCust.GetAllCustomers();
            
        //    if (txtIdCustomer.Text != "")
        //    {
        //        string seleccionado = txtIdCustomer.Text.ToLower();
        //        dgvCustomer.Rows.Clear();

        //        foreach (Customers c in lstCustomers)
        //        {
        //            bool x = c.CustomerID.ToLower().Contains(seleccionado);
        //            if (x)
        //            {
        //                dgvCustomer.Rows.Add(new object[] { c.CustomerID,c.CompanyName,c.ContactName,c.CompanyName,c.ContactTitle,
        //                c.Address,c.City,c.Region,c.PostalCode,c.Country,c.Phone,c.Fax});
        //            }
        //        }
        //    }
        //    else
        //    {
        //        dgvCustomer.Rows.Clear();
        //        foreach (Customers c in lstCustomers)
        //        {
        //            dgvCustomer.Rows.Add(new object[] { c.CustomerID,c.CompanyName,c.ContactName,c.CompanyName,c.ContactTitle,
        //                c.Address,c.City,c.Region,c.PostalCode,c.Country,c.Phone,c.Fax});
        //        }
        //    }
        //}
    }
}
