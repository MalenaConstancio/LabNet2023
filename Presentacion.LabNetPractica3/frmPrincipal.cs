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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void AbrirForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pnlPrincipal.Controls.Add(form);
            pnlPrincipal.Tag = form;
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            AbrirForm(form);
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias form = new frmCategorias();
            AbrirForm(form);
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores form = new frmProveedores();
            AbrirForm(form);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     
    }
}
