namespace KlijentApp
{
    partial class FrmPrijavljivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijavljivanje));
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblKorisnickaSifra = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtKorisnickaSifra = new System.Windows.Forms.TextBox();
            this.btnOkice = new System.Windows.Forms.Button();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(174, 53);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(140, 26);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblKorisnickaSifra
            // 
            this.lblKorisnickaSifra.AutoSize = true;
            this.lblKorisnickaSifra.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickaSifra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKorisnickaSifra.Location = new System.Drawing.Point(174, 109);
            this.lblKorisnickaSifra.Name = "lblKorisnickaSifra";
            this.lblKorisnickaSifra.Size = new System.Drawing.Size(143, 26);
            this.lblKorisnickaSifra.TabIndex = 1;
            this.lblKorisnickaSifra.Text = "Korisnička šifra:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(347, 53);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(197, 33);
            this.txtKorisnickoIme.TabIndex = 2;
            this.txtKorisnickoIme.Text = "tacarica";
            // 
            // txtKorisnickaSifra
            // 
            this.txtKorisnickaSifra.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickaSifra.Location = new System.Drawing.Point(347, 106);
            this.txtKorisnickaSifra.Name = "txtKorisnickaSifra";
            this.txtKorisnickaSifra.Size = new System.Drawing.Size(197, 33);
            this.txtKorisnickaSifra.TabIndex = 3;
            this.txtKorisnickaSifra.Text = "zvezdica";
            this.txtKorisnickaSifra.UseSystemPasswordChar = true;
            // 
            // btnOkice
            // 
            this.btnOkice.Image = ((System.Drawing.Image)(resources.GetObject("btnOkice.Image")));
            this.btnOkice.Location = new System.Drawing.Point(565, 104);
            this.btnOkice.Name = "btnOkice";
            this.btnOkice.Size = new System.Drawing.Size(43, 37);
            this.btnOkice.TabIndex = 4;
            this.btnOkice.UseVisualStyleBackColor = true;
            this.btnOkice.Click += new System.EventHandler(this.btnOkice_Click);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSe.Location = new System.Drawing.Point(436, 173);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(172, 46);
            this.btnPrijaviSe.TabIndex = 5;
            this.btnPrijaviSe.Text = "Prijavi se!";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 171);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrijavljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(639, 250);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.btnOkice);
            this.Controls.Add(this.txtKorisnickaSifra);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickaSifra);
            this.Controls.Add(this.lblKorisnickoIme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrijavljivanje";
            this.Text = "[Filmski festival \"Kulturiška\"] - Prijavljivanje na sistem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaForma_FormClosed);
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickaSifra;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickaSifra;
        private System.Windows.Forms.Button btnOkice;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

