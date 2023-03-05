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
            lstvTransportes.FullRowSelect = true;

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
         
            btnDetener.Visible = true;
            btnConducir.Visible = false;
            lstvTransportes.Visible = false;
            TransportePublico transporte = null;

            string seleccionado = lblListar.Text;
            string[] datosSeleccionado = seleccionado.Split(' ');

            string tipoTransporte = datosSeleccionado[0];
            int cantidadPasajeros = Convert.ToInt32(datosSeleccionado[2]);

            if (tipoTransporte == "Taxi")
            {
                 transporte = new Taxi(cantidadPasajeros, tipoTransporte);
            }
            else if (tipoTransporte == "Omnibus")
            {
                 transporte = new Omnibus(cantidadPasajeros, tipoTransporte);
            }

            lblListar.Text= transporte.Avanzar();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnConducir.Visible = false;
            btnDetener.Visible = false;
            TransportePublico transporte = null;

            string seleccionado = lblListar.Text;
            string[] datosSeleccionado = seleccionado.Split(' ');

            string tipoTransporte = datosSeleccionado[0];
            int cantidadPasajeros = Convert.ToInt32(datosSeleccionado[2]);

            if (tipoTransporte == "Taxi")
            {
                transporte = new Taxi(cantidadPasajeros, tipoTransporte);
            }
            else if (tipoTransporte == "Omnibus")
            {
                transporte = new Omnibus(cantidadPasajeros, tipoTransporte);
            }

            lblListar.Text = transporte.Detenerse();
        }

        private void lstvTransportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList arrTransporteSeleccionado = new ArrayList();
            TransportePublico transporteSeleccionado = null;

            arrTransporteSeleccionado.Add(lstvTransportes.SelectedItems[0].SubItems[0].Text);
            arrTransporteSeleccionado.Add(lstvTransportes.SelectedItems[0].SubItems[1].Text);

            string tipoTransporte = arrTransporteSeleccionado[0].ToString();
            int cantidadPasajeros = Convert.ToInt32(arrTransporteSeleccionado[1]);

            if (tipoTransporte == "Taxi")
            {
                transporteSeleccionado = new Taxi(cantidadPasajeros, tipoTransporte);
            }
            else if (tipoTransporte == "Omnibus")
            {
                transporteSeleccionado = new Omnibus(cantidadPasajeros, tipoTransporte);
            }
            lstvTransportes.Visible = false;
            lblListar.Text=transporteSeleccionado.TipoTransporte+" con "+transporteSeleccionado.CantPasajeros+" pasajeros.";
        }
    }
}
