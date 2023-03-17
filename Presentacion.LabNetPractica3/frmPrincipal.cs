using Presentacion.LabNetPractica3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.LabNetPractica4
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
            pnlQuery.Controls.Add(form);
            pnlQuery.Tag = form;
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            frmQuery1 form = new frmQuery1();
            AbrirForm(form);
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            frmQuery2 form = new frmQuery2();
            AbrirForm(form);

        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            frmQuery3 form = new frmQuery3();
            AbrirForm(form);
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            frmQuery4 form = new frmQuery4();
            AbrirForm(form);
        }
    }
}
