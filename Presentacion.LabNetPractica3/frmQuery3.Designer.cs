
namespace Presentacion.LabNetPractica3
{
    partial class frmQuery3
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnTraer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblQuery1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Image = global::Presentacion.LabNetPractica3.Properties.Resources.iconoClose;
            this.btnClose.Location = new System.Drawing.Point(864, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 336);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(892, 251);
            this.dgvProducts.TabIndex = 9;
            // 
            // btnTraer
            // 
            this.btnTraer.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTraer.Location = new System.Drawing.Point(12, 290);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(846, 40);
            this.btnTraer.TabIndex = 10;
            this.btnTraer.Text = "TRAER PRODUCTOS CON STOCK Y PRECIO UNITARIO > 3";
            this.btnTraer.UseVisualStyleBackColor = false;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::Presentacion.LabNetPractica3.Properties.Resources.iconoRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(864, 290);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblQuery1
            // 
            this.lblQuery1.AutoSize = true;
            this.lblQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuery1.Location = new System.Drawing.Point(12, 34);
            this.lblQuery1.Name = "lblQuery1";
            this.lblQuery1.Size = new System.Drawing.Size(642, 18);
            this.lblQuery1.TabIndex = 12;
            this.lblQuery1.Text = "3. Query para devolver todos los productos que tienen stock y que cuestan más de " +
    "3 por unidad.";
            // 
            // frmQuery3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 625);
            this.ControlBox = false;
            this.Controls.Add(this.lblQuery1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnClose);
            this.Name = "frmQuery3";
            this.Load += new System.EventHandler(this.frmQuery3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblQuery1;
    }
}