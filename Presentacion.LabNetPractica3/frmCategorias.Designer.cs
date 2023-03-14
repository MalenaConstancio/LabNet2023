
namespace Presentacion.LabNetPractica3
{
    partial class frmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dgvProductosXCategoria = new System.Windows.Forms.DataGridView();
            this.gbxCategorias = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosXCategoria
            // 
            this.dgvProductosXCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosXCategoria.Location = new System.Drawing.Point(55, 333);
            this.dgvProductosXCategoria.Name = "dgvProductosXCategoria";
            this.dgvProductosXCategoria.Size = new System.Drawing.Size(848, 273);
            this.dgvProductosXCategoria.TabIndex = 0;
            // 
            // gbxCategorias
            // 
            this.gbxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategorias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCategorias.Location = new System.Drawing.Point(55, 62);
            this.gbxCategorias.Name = "gbxCategorias";
            this.gbxCategorias.Size = new System.Drawing.Size(848, 238);
            this.gbxCategorias.TabIndex = 1;
            this.gbxCategorias.TabStop = false;
            this.gbxCategorias.Text = "Datos de Categoria";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(913, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 34);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxCategorias);
            this.Controls.Add(this.dgvProductosXCategoria);
            this.Name = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosXCategoria;
        private System.Windows.Forms.GroupBox gbxCategorias;
        private System.Windows.Forms.Button btnCerrar;
    }
}