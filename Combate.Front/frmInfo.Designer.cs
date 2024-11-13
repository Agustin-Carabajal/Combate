namespace Combate.Front
{
    partial class frmInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLA = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLA
            // 
            this.lblLA.AutoSize = true;
            this.lblLA.BackColor = System.Drawing.Color.Transparent;
            this.lblLA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLA.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLA.Location = new System.Drawing.Point(89, 19);
            this.lblLA.Name = "lblLA";
            this.lblLA.Size = new System.Drawing.Size(327, 36);
            this.lblLA.TabIndex = 1;
            this.lblLA.Text = "LISTADO DE ARMAS";
            // 
            // DGVListado
            // 
            this.DGVListado.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListado.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListado.GridColor = System.Drawing.Color.Gainsboro;
            this.DGVListado.Location = new System.Drawing.Point(12, 74);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.Size = new System.Drawing.Size(476, 143);
            this.DGVListado.TabIndex = 2;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Combate.Front.Properties.Resources.bgrBullets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.DGVListado);
            this.Controls.Add(this.lblLA);
            this.Name = "frmInfo";
            this.Text = "Información";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLA;
        private System.Windows.Forms.DataGridView DGVListado;
    }
}