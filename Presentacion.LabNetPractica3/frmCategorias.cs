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
using Entidades.LabNetPractica3;
using Negocio.LabNetPractica3;

namespace Presentacion.LabNetPractica3
{
    public partial class frmCategorias : Form
    {
        NCategories negCat = new NCategories();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
           
           

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnAgregar.Visible = false;
            

            //if (e.ColumnIndex == 3)
            //{
            //    btnAceptar.Visible = true;
            //    try
            //    {
            //        int filaSeleccionada = dgvCategorias.CurrentRow.Index;
            //        int idCatergoria = Convert.ToInt32(dgvCategorias.Rows[filaSeleccionada].Cells[0].Value);
            //        string nombreCategoria = dgvCategorias.Rows[filaSeleccionada].Cells[1].Value.ToString();
            //        string descripcionCategoria = dgvCategorias.Rows[filaSeleccionada].Cells[2].Value.ToString();
            //        txtId.Text = idCatergoria.ToString();
            //        txtNombre.Text = nombreCategoria;
            //        txtDescripcion.Text = descripcionCategoria;
            //        dgvCategorias.Visible = false;
            //    }
            //    catch (Exception) {
            //        throw;
            //    }


            //}
            //else if (e.ColumnIndex == 4) 
            //{
            //    if (MessageBox.Show("Seguro que desea eliminar la categoria?\n**Recuerde que solo puede eliminar Categorias \nque aun no tengan asignados Productos**", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { 
            //        try
            //        {
            //            int filaSeleccionada = dgvCategorias.CurrentRow.Index;
            //            int idCatergoria = Convert.ToInt32(dgvCategorias.Rows[filaSeleccionada].Cells[0].Value);
            //            Categories cat = new Categories();
            //            cat.CategoryID = idCatergoria;
            //            negCat.Delete(cat);
            //            MessageBox.Show("Se elimino correctamente la Categoria", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            dgvCategorias.DataSource = negCat.GetAll();
            //            btnAgregar.Visible = true;
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("No se pudo eliminar la Categoria seleccionada", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            btnAgregar.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        btnAgregar.Visible = true;
            //    }
            //}

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        Categories cat = new Categories();
        //        cat.CategoryID = Convert.ToInt32(txtId.Text);
        //        cat.CategoryName = txtNombre.Text;
        //        cat.Description = txtDescripcion.Text;
        //        negCat.Update(cat);
        //        MessageBox.Show("Se editó correctamente la Categoria", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        LimpiarCampos();
        //        dgvCategorias.DataSource = negCat.GetAll();
        //        btnAgregar.Visible = true;
        //        btnAceptar.Visible = false;
        //        dgvCategorias.Visible = true;
        //    }
        //    catch (Exception) {
        //        MessageBox.Show("No se pudo editar la Categoria", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        LimpiarCampos();
        //        btnAgregar.Visible = true;
        //        btnAceptar.Visible = false;
        //    }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        Categories cat = new Categories();
        //        cat.CategoryName = txtNombre.Text;
        //        cat.Description = txtDescripcion.Text;
        //        if (negCat.Add(cat)) { 
        //        MessageBox.Show("Se agrego correctamente la Categoria", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        LimpiarCampos();
        //        dgvCategorias.DataSource = negCat.GetAll();
        //        }
        //        else{
        //            MessageBox.Show("La Categoria ya existe", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            LimpiarCampos();
        //        }
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show("No se pudo agregar la Categoria", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        LimpiarCampos();
        //    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos() {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtId.Text = "";
        }


        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
