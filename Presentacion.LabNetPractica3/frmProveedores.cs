using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.LabNetPractica3;
using Entidades.LabNetPractica3;

namespace Presentacion.LabNetPractica3
{
    public partial class frmProveedores : Form
    {
        NProveedor negProv = new NProveedor();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = negProv.GetAll();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Suppliers supp = new Suppliers();
                supp.CompanyName = txtCompania.Text;
                supp.ContactName = txtContacto.Text;
                supp.Phone = txtContacto.Text;
                if (negProv.Add(supp))
                {
                    MessageBox.Show("Se agrego correctamente el Proveedor", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    dgvProveedores.DataSource = negProv.GetAll();
                }
                else
                {
                    MessageBox.Show("El Proveedor ya existe", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Proveedor", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                Suppliers supp = new Suppliers();
                supp.SupplierID = Convert.ToInt32(txtId.Text);
                supp.CompanyName = txtCompania.Text;
                supp.ContactName = txtContacto.Text;
                supp.Phone = txtTelefono.Text;
                negProv.Update(supp);
                MessageBox.Show("Se editó correctamente el Proveedor", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                dgvProveedores.DataSource = negProv.GetAll();
                btnAgregarProveedor.Visible = true;
                btnEditarProveedor.Visible = false;
                dgvProveedores.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo editar el Proveedor", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
                btnAgregarProveedor.Visible = true;
                btnEditarProveedor.Visible = false;
            }

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnAgregarProveedor.Visible = false;


            if (e.ColumnIndex == 8)
            {
                btnEditarProveedor.Visible = true;
                try
                {
                    int filaSeleccionada = dgvProveedores.CurrentRow.Index;
                    int idProveedor = Convert.ToInt32(dgvProveedores.Rows[filaSeleccionada].Cells[0].Value);
                    string nombre = dgvProveedores.Rows[filaSeleccionada].Cells[1].Value.ToString();
                    string contacto = dgvProveedores.Rows[filaSeleccionada].Cells[2].Value.ToString();
                    string telefono = dgvProveedores.Rows[filaSeleccionada].Cells[6].Value.ToString();
                    txtId.Text = idProveedor.ToString();
                    txtCompania.Text = nombre;
                    txtContacto.Text = contacto;
                    txtTelefono.Text = telefono;
                    dgvProveedores.Visible = false;
                }
                catch (Exception)
                {
                    throw;
                }


            }
            else if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Seguro que desea eliminar el Proveedor?\n**Recuerde que solo puede eliminar Proveedores \nque aun no tengan asignados Productos**", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        int filaSeleccionada = dgvProveedores.CurrentRow.Index;
                        int idProveedor = Convert.ToInt32(dgvProveedores.Rows[filaSeleccionada].Cells[0].Value);
                        Suppliers supp = new Suppliers();
                        supp.SupplierID = idProveedor;
                        negProv.Delete(supp);
                        dgvProveedores.DataSource = negProv.GetAll();
                        MessageBox.Show("Se elimino correctamente el Proveedor", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnAgregarProveedor.Visible = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo eliminar el Proveedor seleccionado", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnAgregarProveedor.Visible = true;
                    }
                }
                else
                {
                    btnAgregarProveedor.Visible = true;
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCompania.Text = "";
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
        }


        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
