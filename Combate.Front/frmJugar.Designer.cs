namespace Combate.Front
{
    partial class frmJugar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEnem = new System.Windows.Forms.Label();
            this.lblEnemVida = new System.Windows.Forms.Label();
            this.lblJugNom = new System.Windows.Forms.Label();
            this.lblJugVida = new System.Windows.Forms.Label();
            this.btnPistola = new System.Windows.Forms.Button();
            this.btnHacha = new System.Windows.Forms.Button();
            this.btnEspada = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.imgBang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Combate.Front.Properties.Resources.imgEnem;
            this.pictureBox1.Location = new System.Drawing.Point(127, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnem
            // 
            this.lblEnem.AutoSize = true;
            this.lblEnem.BackColor = System.Drawing.Color.Transparent;
            this.lblEnem.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnem.Location = new System.Drawing.Point(122, 76);
            this.lblEnem.Name = "lblEnem";
            this.lblEnem.Size = new System.Drawing.Size(68, 25);
            this.lblEnem.TabIndex = 1;
            this.lblEnem.Text = "label1";
            // 
            // lblEnemVida
            // 
            this.lblEnemVida.AutoSize = true;
            this.lblEnemVida.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemVida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemVida.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblEnemVida.Location = new System.Drawing.Point(208, 76);
            this.lblEnemVida.Name = "lblEnemVida";
            this.lblEnemVida.Size = new System.Drawing.Size(68, 25);
            this.lblEnemVida.TabIndex = 2;
            this.lblEnemVida.Text = "label1";
            // 
            // lblJugNom
            // 
            this.lblJugNom.AutoSize = true;
            this.lblJugNom.BackColor = System.Drawing.Color.Transparent;
            this.lblJugNom.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugNom.Location = new System.Drawing.Point(667, 226);
            this.lblJugNom.Name = "lblJugNom";
            this.lblJugNom.Size = new System.Drawing.Size(63, 24);
            this.lblJugNom.TabIndex = 3;
            this.lblJugNom.Text = "label1";
            // 
            // lblJugVida
            // 
            this.lblJugVida.AutoSize = true;
            this.lblJugVida.BackColor = System.Drawing.Color.Transparent;
            this.lblJugVida.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugVida.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblJugVida.Location = new System.Drawing.Point(667, 268);
            this.lblJugVida.Name = "lblJugVida";
            this.lblJugVida.Size = new System.Drawing.Size(105, 24);
            this.lblJugVida.TabIndex = 4;
            this.lblJugVida.Text = "lblJugVida";
            // 
            // btnPistola
            // 
            this.btnPistola.BackColor = System.Drawing.Color.DarkGray;
            this.btnPistola.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPistola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPistola.Location = new System.Drawing.Point(661, 366);
            this.btnPistola.Name = "btnPistola";
            this.btnPistola.Size = new System.Drawing.Size(85, 49);
            this.btnPistola.TabIndex = 5;
            this.btnPistola.Text = "PISTOLA";
            this.btnPistola.UseVisualStyleBackColor = false;
            this.btnPistola.Click += new System.EventHandler(this.btnPistola_Click);
            // 
            // btnHacha
            // 
            this.btnHacha.BackColor = System.Drawing.Color.DarkGray;
            this.btnHacha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacha.Location = new System.Drawing.Point(558, 366);
            this.btnHacha.Name = "btnHacha";
            this.btnHacha.Size = new System.Drawing.Size(85, 49);
            this.btnHacha.TabIndex = 6;
            this.btnHacha.Text = "HACHA";
            this.btnHacha.UseVisualStyleBackColor = false;
            this.btnHacha.Click += new System.EventHandler(this.btnHacha_Click);
            // 
            // btnEspada
            // 
            this.btnEspada.BackColor = System.Drawing.Color.DarkGray;
            this.btnEspada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEspada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspada.Location = new System.Drawing.Point(457, 366);
            this.btnEspada.Name = "btnEspada";
            this.btnEspada.Size = new System.Drawing.Size(85, 49);
            this.btnEspada.TabIndex = 7;
            this.btnEspada.Text = "ESPADA";
            this.btnEspada.UseVisualStyleBackColor = false;
            this.btnEspada.Click += new System.EventHandler(this.btnEspada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Combate.Front.Properties.Resources.espada;
            this.pictureBox2.Location = new System.Drawing.Point(472, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Combate.Front.Properties.Resources.hacha;
            this.pictureBox3.Location = new System.Drawing.Point(573, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Combate.Front.Properties.Resources.pistola;
            this.pictureBox4.Location = new System.Drawing.Point(676, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // imgBang
            // 
            this.imgBang.BackColor = System.Drawing.Color.Transparent;
            this.imgBang.Image = global::Combate.Front.Properties.Resources.bang;
            this.imgBang.Location = new System.Drawing.Point(1, 104);
            this.imgBang.Name = "imgBang";
            this.imgBang.Size = new System.Drawing.Size(425, 256);
            this.imgBang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBang.TabIndex = 11;
            this.imgBang.TabStop = false;
            // 
            // frmJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Combate.Front.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEnem);
            this.Controls.Add(this.lblEnemVida);
            this.Controls.Add(this.btnEspada);
            this.Controls.Add(this.btnHacha);
            this.Controls.Add(this.btnPistola);
            this.Controls.Add(this.lblJugVida);
            this.Controls.Add(this.lblJugNom);
            this.Controls.Add(this.imgBang);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmJugar";
            this.Text = "¡Combate de Armas!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CerrarJ);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnem;
        private System.Windows.Forms.Label lblEnemVida;
        private System.Windows.Forms.Label lblJugNom;
        private System.Windows.Forms.Label lblJugVida;
        private System.Windows.Forms.Button btnPistola;
        private System.Windows.Forms.Button btnHacha;
        private System.Windows.Forms.Button btnEspada;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox imgBang;
    }
}