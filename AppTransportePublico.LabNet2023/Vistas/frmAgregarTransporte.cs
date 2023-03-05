using AppTransportePublico.LabNet2023.Entidades;
using AppTransportePublico.LabNet2023.Negocio.Implementaciones;
using AppTransportePublico.LabNet2023.Negocio.Interfaces;
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
    public partial class frmAgregarTransporte : Form
    {
        ITransportePublico tpneg = new NTransportePublico();
        private List<TransportePublico> lstTransportes= null;

        public List<TransportePublico> LstTransportes
        {
            
            set { lstTransportes = value; }
        }

        public frmAgregarTransporte()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarCampos();
        }

        private void frmAgregarTransporte_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string tipo = cbxTipoTransporte.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(txtCantidadPasajeros.Text);

            if ((tipo == "Omnibus") && (cantidad < Omnibus.cantMaxPasajeros))
            {

                TipoTransporte oTipoTransporte = new TipoTransporte(0, "Omnibus");
                TransportePublico oOmnibus =  new Omnibus(cantidad, oTipoTransporte);
                //Omnibus oOmnibus = new Omnibus(cantidad, oTipoTransporte);
                tpneg.AgregarTransporte(lstTransportes, oOmnibus);
                LimpiarCampos();

            }

            if ((tipo == "Taxi") && (cantidad < Taxi.cantMaxPasajeros))
            {

                TipoTransporte oTipoTransporte = new TipoTransporte(1, "Taxi");
                Taxi oTaxi = new Taxi(cantidad, oTipoTransporte);
                tpneg.AgregarTransporte(lstTransportes, oTaxi);
                LimpiarCampos();

            }

        }

        public void LimpiarCampos() {
            cbxTipoTransporte.SelectedIndex = -1;
            txtCantidadPasajeros.Text = "";
        }
    }
}
