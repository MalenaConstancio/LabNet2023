
namespace Presentacion.LabNetPractica4
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.LightGray;
            this.pnlBotonera.Controls.Add(this.btnProveedores);
            this.pnlBotonera.Controls.Add(this.btnSalir);
            this.pnlBotonera.Controls.Add(this.btnCategorias);
            this.pnlBotonera.Controls.Add(this.btnProductos);
            this.pnlBotonera.Controls.Add(this.imgLogo);
            this.pnlBotonera.Location = new System.Drawing.Point(5, 2);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(156, 681);
            this.pnlBotonera.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(166, 2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(972, 680);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.SystemColors.Control;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(3, 286);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(150, 41);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "        PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 637);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR ";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.SystemColors.Control;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(3, 239);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(150, 41);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "       CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.Control;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(3, 192);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 41);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "        PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(156, 141);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 688);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBotonera);
            this.Name = "frmPrincipal";
            this.pnlBotonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnProveedores;
    }
}