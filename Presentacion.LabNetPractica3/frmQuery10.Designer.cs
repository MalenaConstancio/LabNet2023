
namespace Presentacion.LabNetPractica3
{
    partial class frmQuery10
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblQuery1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 350);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(892, 251);
            this.dgvProducts.TabIndex = 13;
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.SystemColors.Control;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProbar.Location = new System.Drawing.Point(12, 304);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(846, 40);
            this.btnProbar.TabIndex = 17;
            this.btnProbar.Text = "PROBAR";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::Presentacion.LabNetPractica3.Properties.Resources.iconoRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(864, 304);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 18;
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
            this.lblQuery1.Size = new System.Drawing.Size(598, 18);
            this.lblQuery1.TabIndex = 20;
            this.lblQuery1.Text = "10. Query para devolver lista de productos ordenados por unit in stock de mayor a" +
    " menor.";
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
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmQuery10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 625);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblQuery1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.dgvProducts);
            this.Name = "frmQuery10";
            this.Load += new System.EventHandler(this.frmQuery10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblQuery1;
        private System.Windows.Forms.Button btnClose;
    }
}