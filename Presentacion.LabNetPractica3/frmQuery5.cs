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
    public partial class frmQuery5 : Form
    {
        NProducts negPRod = new NProducts();
        public frmQuery5()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void frmQuery5_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = negPRod.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = negPRod.GetAll();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id=0;
            try
            {
                 id = Convert.ToInt32(txtIdProduct.Text);

                Products p = negPRod.GetFirstOrNull(id);
                if (p != null)
                {
                    List<Products> lstUnProducto = new List<Products>();
                    lstUnProducto.Add(p);
                    dgvProduct.DataSource = lstUnProducto;
                    txtIdProduct.Text = " ";
                }
                else
                {
                    MessageBox.Show("No existe el Id ingresado", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdProduct.Text = " ";
                }
            }
            catch (Exception) {
                MessageBox.Show("Verifique el formato del Id ingresado", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdProduct.Text = " ";
            }
           
          
            
        }
    }
}
