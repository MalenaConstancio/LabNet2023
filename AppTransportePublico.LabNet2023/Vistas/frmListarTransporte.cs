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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListarTransporte_Load(object sender, EventArgs e)
        {
            lstvTransportes.View = View.Details;

            foreach (TransportePublico transporte in lstTransportes)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = true;
                item.Text = transporte.TipoTransporte.NombreTipoTransporte;
                item.SubItems.Add(transporte.CantPasajeros.ToString());
                lstvTransportes.Items.Add(item);
            }
        }
    }
}
