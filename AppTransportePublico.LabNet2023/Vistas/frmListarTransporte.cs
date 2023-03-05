using AppTransportePublico.LabNet2023.Entidades;
using AppTransportePublico.LabNet2023.Negocio.Implementaciones;
using AppTransportePublico.LabNet2023.Negocio.Interfaces;
using System;
using System.Collections;
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
    public partial class frmListarTransporte : Form
    {
        ITransportePublico tpneg = new NTransportePublico();
        private List<TransportePublico> lstTransportes = null;

        public List<TransportePublico> LstTransportes
        {

            set { lstTransportes = value; }
        }

        public frmListarTransporte()
        {
            InitializeComponent();
        }

        private void frmListarTransporte_Load(object sender, EventArgs e)
        {
            lstvTransportes.View = View.Details;
            

            foreach (TransportePublico transporte in lstTransportes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = transporte.TipoTransporte;
                item.SubItems.Add(transporte.CantPasajeros.ToString());
                
                lstvTransportes.Items.Add(item);
            }
           
            lstvTransportes.Columns.Add("Transporte", -1, HorizontalAlignment.Center);
            lstvTransportes.Columns[0].Width = 80;
            lstvTransportes.Columns.Add("Pasajeros", -1, HorizontalAlignment.Center);
            lstvTransportes.Columns[1].Width = 80;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConducir_Click(object sender, EventArgs e)
        {
            ArrayList arrTransporteSeleccionado = new ArrayList();
            TransportePublico transporteSeleccionado = null;
            arrTransporteSeleccionado.Add(lstvTransportes.SelectedItems);

            if (arrTransporteSeleccionado[0].ToString() == "Taxi")
            {
               transporteSeleccionado = new Taxi((int)arrTransporteSeleccionado[0], arrTransporteSeleccionado[1].ToString());
            }
            else if (arrTransporteSeleccionado[0].ToString() == "Omnibus") {
               transporteSeleccionado = new Omnibus((int)arrTransporteSeleccionado[0], arrTransporteSeleccionado[1].ToString());
            }
            lblListar.Text = transporteSeleccionado.Avanzar();
            btnDetener.Visible = true;

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
           
        }

     
    }
}
