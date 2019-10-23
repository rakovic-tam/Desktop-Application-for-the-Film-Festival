namespace KlijentApp
{
    partial class FrmUnosMedijskeKuce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosMedijskeKuce));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtMedijskaKucaID = new System.Windows.Forms.TextBox();
            this.lblMedijskaKucaID = new System.Windows.Forms.Label();
            this.gbMK = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtVlasnikMK = new System.Windows.Forms.TextBox();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.txtNazivMK = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(179, 37);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(78, 34);
            this.btnKreiraj.TabIndex = 8;
            this.btnKreiraj.Text = "Kreiraj!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtMedijskaKucaID
            // 
            this.txtMedijskaKucaID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedijskaKucaID.Location = new System.Drawing.Point(77, 40);
            this.txtMedijskaKucaID.Name = "txtMedijskaKucaID";
            this.txtMedijskaKucaID.ReadOnly = true;
            this.txtMedijskaKucaID.Size = new System.Drawing.Size(65, 29);
            this.txtMedijskaKucaID.TabIndex = 7;
            // 
            // lblMedijskaKucaID
            // 
            this.lblMedijskaKucaID.AutoSize = true;
            this.lblMedijskaKucaID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedijskaKucaID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMedijskaKucaID.Location = new System.Drawing.Point(21, 43);
            this.lblMedijskaKucaID.Name = "lblMedijskaKucaID";
            this.lblMedijskaKucaID.Size = new System.Drawing.Size(31, 22);
            this.lblMedijskaKucaID.TabIndex = 6;
            this.lblMedijskaKucaID.Text = "ID:";
            // 
            // gbMK
            // 
            this.gbMK.Controls.Add(this.btnSacuvaj);
            this.gbMK.Controls.Add(this.txtVlasnikMK);
            this.gbMK.Controls.Add(this.lblVlasnik);
            this.gbMK.Controls.Add(this.txtNazivMK);
            this.gbMK.Controls.Add(this.lblNaziv);
            this.gbMK.Enabled = false;
            this.gbMK.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMK.Location = new System.Drawing.Point(24, 91);
            this.gbMK.Name = "gbMK";
            this.gbMK.Size = new System.Drawing.Size(510, 234);
            this.gbMK.TabIndex = 9;
            this.gbMK.TabStop = false;
            this.gbMK.Text = "Podaci o medijskoj kući";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacuvaj.Location = new System.Drawing.Point(168, 158);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 46);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj!";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtVlasnikMK
            // 
            this.txtVlasnikMK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlasnikMK.Location = new System.Drawing.Point(232, 98);
            this.txtVlasnikMK.Name = "txtVlasnikMK";
            this.txtVlasnikMK.Size = new System.Drawing.Size(249, 29);
            this.txtVlasnikMK.TabIndex = 13;
            // 
            // lblVlasnik
            // 
            this.lblVlasnik.AutoSize = true;
            this.lblVlasnik.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlasnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVlasnik.Location = new System.Drawing.Point(20, 101);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(164, 22);
            this.lblVlasnik.TabIndex = 12;
            this.lblVlasnik.Text = "Vlasnik medijske kuće:";
            // 
            // txtNazivMK
            // 
            this.txtNazivMK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivMK.Location = new System.Drawing.Point(232, 46);
            this.txtNazivMK.Name = "txtNazivMK";
            this.txtNazivMK.Size = new System.Drawing.Size(249, 29);
            this.txtNazivMK.TabIndex = 11;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaziv.Location = new System.Drawing.Point(20, 50);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(155, 22);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv medijske kuće:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 67);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(322, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 67);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FrmUnosMedijskeKuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(562, 430);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbMK);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtMedijskaKucaID);
            this.Controls.Add(this.lblMedijskaKucaID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUnosMedijskeKuce";
            this.Text = "[Filmski festival \"Kulturiška\"] - Unos medijske kuće";
            this.Load += new System.EventHandler(this.FrmUnosMedijskeKuce_Load);
            this.gbMK.ResumeLayout(false);
            this.gbMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtMedijskaKucaID;
        private System.Windows.Forms.Label lblMedijskaKucaID;
        private System.Windows.Forms.GroupBox gbMK;
        private System.Windows.Forms.TextBox txtVlasnikMK;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.TextBox txtNazivMK;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}