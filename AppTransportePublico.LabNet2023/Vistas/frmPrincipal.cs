using AppTransportePublico.LabNet2023.Entidades;
using AppTransportePublico.LabNet2023.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTransportePublico.LabNet2023.Vistas
{
    public partial class frmPrincipal : Form
    {

        List<TransportePublico> lstTransportes = new List<TransportePublico>();

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarTransporte agregarTransporte = new frmAgregarTransporte();
            agregarTransporte.LstTransportes = lstTransportes;
            AbrirForm(agregarTransporte);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarTransporte listarTransporte = new frmListarTransporte();
            listarTransporte.LstTransportes = lstTransportes;
            AbrirForm(listarTransporte);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
