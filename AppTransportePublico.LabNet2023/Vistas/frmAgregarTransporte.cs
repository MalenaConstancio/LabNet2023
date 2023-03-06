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
            lblMensaje.Text = "";
            if (cbxTipoTransporte.SelectedItem != null && txtCantidadPasajeros.Text!="")
            {
                string tipo = cbxTipoTransporte.SelectedItem.ToString();
                int cantidad = Convert.ToInt32(txtCantidadPasajeros.Text);

                if (cantidad > 0)
                {
                    if ((tipo == "Omnibus") && (cantidad <= Omnibus.cantMaxPasajeros))
                    {
                        TransportePublico oOmnibus = new Omnibus(cantidad, "Omnibus");
                        if (tpneg.AgregarTransporte(lstTransportes, oOmnibus) != null)
                        {
                            MessageBox.Show("Se agrego el transporte con exito");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Se completo el cupo de 5 Omnibus");
                            LimpiarCampos();
                        }
                    }
                    else if ((tipo == "Taxi") && (cantidad <= Taxi.cantMaxPasajeros))
                    {
                        Taxi oTaxi = new Taxi(cantidad, "Taxi");
                        if (tpneg.AgregarTransporte(lstTransportes, oTaxi) != null)
                        {
                            MessageBox.Show("Se agrego el transporte con exito");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Se completo el cupo de 5 Taxis");
                            LimpiarCampos();
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "Supera la cantidad máxima de pasajeros.\nTaxi = 4\nOmnibus=100";
                    }
                }
                else {
                    lblMensaje.Text = "Debe ingresar una cantidad mayor a 0 \n de pasajeros.";
                }
            }
            else
            {
                lblMensaje.Text = "Debe seleccionar un tipo de transporte.\nDebe ingresar una cantidad de pasajeros.";
            }
        }

        private void LimpiarCampos() {
            cbxTipoTransporte.SelectedIndex = -1;
            txtCantidadPasajeros.Text = "";
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
