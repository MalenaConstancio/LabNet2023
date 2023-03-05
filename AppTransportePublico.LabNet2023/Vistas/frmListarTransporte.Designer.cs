
namespace AppTransportePublico.LabNet2023.Vistas
{
    partial class frmListarTransporte
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
            this.lstvTransportes = new System.Windows.Forms.ListView();
            this.btnConducir = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Label();
            this.gbxListar = new System.Windows.Forms.GroupBox();
            this.gbxListar.SuspendLayout();
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
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lstvTransportes
            // 
            this.lstvTransportes.HideSelection = false;
            this.lstvTransportes.Location = new System.Drawing.Point(38, 33);
            this.lstvTransportes.Name = "lstvTransportes";
            this.lstvTransportes.Size = new System.Drawing.Size(176, 181);
            this.lstvTransportes.TabIndex = 1;
            this.lstvTransportes.UseCompatibleStateImageBehavior = false;
            this.lstvTransportes.View = System.Windows.Forms.View.List;
            this.lstvTransportes.SelectedIndexChanged += new System.EventHandler(this.lstvTransportes_SelectedIndexChanged);
            // 
            // btnConducir
            // 
            this.btnConducir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConducir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConducir.Location = new System.Drawing.Point(241, 73);
            this.btnConducir.Name = "btnConducir";
            this.btnConducir.Size = new System.Drawing.Size(73, 34);
            this.btnConducir.TabIndex = 2;
            this.btnConducir.Text = "CONDUCIR";
            this.btnConducir.UseVisualStyleBackColor = false;
            this.btnConducir.Click += new System.EventHandler(this.btnConducir_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDetener.Location = new System.Drawing.Point(241, 180);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(73, 34);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Visible = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblListar.Location = new System.Drawing.Point(29, 301);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(218, 16);
            this.lblListar.TabIndex = 4;
            this.lblListar.Text = "Seleccione el transporte a conducir";
            // 
            // gbxListar
            // 
            this.gbxListar.Controls.Add(this.btnDetener);
            this.gbxListar.Controls.Add(this.btnConducir);
            this.gbxListar.Controls.Add(this.lstvTransportes);
            this.gbxListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbxListar.Location = new System.Drawing.Point(32, 48);
            this.gbxListar.Name = "gbxListar";
            this.gbxListar.Size = new System.Drawing.Size(337, 229);
            this.gbxListar.TabIndex = 5;
            this.gbxListar.TabStop = false;
            this.gbxListar.Text = "Seleccione el transporte a conducir";
            // 
            // frmListarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 343);
            this.ControlBox = false;
            this.Controls.Add(this.gbxListar);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmListarTransporte";
            this.Load += new System.EventHandler(this.frmListarTransporte_Load);
            this.gbxListar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ListView lstvTransportes;
        private System.Windows.Forms.Button btnConducir;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.GroupBox gbxListar;
    }
}