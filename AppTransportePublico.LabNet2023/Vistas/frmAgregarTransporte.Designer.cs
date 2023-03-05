
namespace AppTransportePublico.LabNet2023.Vistas
{
    partial class frmAgregarTransporte
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grbxDatosTransporte = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.cbxTipoTransporte = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grbxDatosTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCerrar.Location = new System.Drawing.Point(369, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grbxDatosTransporte
            // 
            this.grbxDatosTransporte.Controls.Add(this.label2);
            this.grbxDatosTransporte.Controls.Add(this.label1);
            this.grbxDatosTransporte.Controls.Add(this.txtCantidadPasajeros);
            this.grbxDatosTransporte.Controls.Add(this.cbxTipoTransporte);
            this.grbxDatosTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxDatosTransporte.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbxDatosTransporte.Location = new System.Drawing.Point(33, 59);
            this.grbxDatosTransporte.Name = "grbxDatosTransporte";
            this.grbxDatosTransporte.Size = new System.Drawing.Size(336, 128);
            this.grbxDatosTransporte.TabIndex = 2;
            this.grbxDatosTransporte.TabStop = false;
            this.grbxDatosTransporte.Text = "Datos del Transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de Pasajeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo ";
            // 
            // txtCantidadPasajeros
            // 
            this.txtCantidadPasajeros.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadPasajeros.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCantidadPasajeros.Location = new System.Drawing.Point(180, 74);
            this.txtCantidadPasajeros.MaxLength = 3;
            this.txtCantidadPasajeros.Name = "txtCantidadPasajeros";
            this.txtCantidadPasajeros.Size = new System.Drawing.Size(121, 21);
            this.txtCantidadPasajeros.TabIndex = 1;
            this.txtCantidadPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_KeyPress);
            // 
            // cbxTipoTransporte
            // 
            this.cbxTipoTransporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxTipoTransporte.FormattingEnabled = true;
            this.cbxTipoTransporte.Items.AddRange(new object[] {
            "Omnibus",
            "Taxi"});
            this.cbxTipoTransporte.Location = new System.Drawing.Point(180, 33);
            this.cbxTipoTransporte.Name = "cbxTipoTransporte";
            this.cbxTipoTransporte.Size = new System.Drawing.Size(121, 23);
            this.cbxTipoTransporte.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAceptar.Location = new System.Drawing.Point(292, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(73, 34);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Location = new System.Drawing.Point(213, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMensaje.Location = new System.Drawing.Point(86, 287);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 18);
            this.lblMensaje.TabIndex = 5;
            // 
            // frmAgregarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 343);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbxDatosTransporte);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmAgregarTransporte";
            this.Load += new System.EventHandler(this.frmAgregarTransporte_Load);
            this.grbxDatosTransporte.ResumeLayout(false);
            this.grbxDatosTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox grbxDatosTransporte;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidadPasajeros;
        private System.Windows.Forms.ComboBox cbxTipoTransporte;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}