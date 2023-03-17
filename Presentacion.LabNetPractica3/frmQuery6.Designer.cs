
namespace Presentacion.LabNetPractica3
{
    partial class frmQuery6
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblQuery1 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMayuscula = new System.Windows.Forms.Button();
            this.btnMinuscula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
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
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 349);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(892, 251);
            this.dgvCustomers.TabIndex = 10;
            // 
            // lblQuery1
            // 
            this.lblQuery1.AutoSize = true;
            this.lblQuery1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQuery1.Location = new System.Drawing.Point(9, 41);
            this.lblQuery1.Name = "lblQuery1";
            this.lblQuery1.Size = new System.Drawing.Size(571, 36);
            this.lblQuery1.TabIndex = 11;
            this.lblQuery1.Text = "6. Query para devolver los nombres de los Customers. Mostrarlos en Mayuscula y en" +
    "\r\nMinuscula.";
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.SystemColors.Control;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProbar.Location = new System.Drawing.Point(12, 303);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(716, 40);
            this.btnProbar.TabIndex = 12;
            this.btnProbar.Text = "PROBAR";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::Presentacion.LabNetPractica3.Properties.Resources.iconoRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(864, 303);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMayuscula
            // 
            this.btnMayuscula.BackColor = System.Drawing.SystemColors.Control;
            this.btnMayuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayuscula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMayuscula.Location = new System.Drawing.Point(734, 303);
            this.btnMayuscula.Name = "btnMayuscula";
            this.btnMayuscula.Size = new System.Drawing.Size(40, 40);
            this.btnMayuscula.TabIndex = 14;
            this.btnMayuscula.Text = "M";
            this.btnMayuscula.UseVisualStyleBackColor = false;
            this.btnMayuscula.Click += new System.EventHandler(this.btnMayuscula_Click);
            // 
            // btnMinuscula
            // 
            this.btnMinuscula.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuscula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinuscula.Location = new System.Drawing.Point(780, 303);
            this.btnMinuscula.Name = "btnMinuscula";
            this.btnMinuscula.Size = new System.Drawing.Size(40, 40);
            this.btnMinuscula.TabIndex = 15;
            this.btnMinuscula.Text = "m";
            this.btnMinuscula.UseVisualStyleBackColor = false;
            this.btnMinuscula.Click += new System.EventHandler(this.btnMinuscula_Click);
            // 
            // frmQuery6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 625);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinuscula);
            this.Controls.Add(this.btnMayuscula);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.lblQuery1);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnClose);
            this.Name = "frmQuery6";
            this.Load += new System.EventHandler(this.frmQuery6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblQuery1;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMayuscula;
        private System.Windows.Forms.Button btnMinuscula;
    }
}