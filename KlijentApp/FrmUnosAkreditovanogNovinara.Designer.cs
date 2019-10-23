namespace KlijentApp
{
    partial class frmUnosAkreditovanogNovinara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosAkreditovanogNovinara));
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtAkrNovinarID = new System.Windows.Forms.TextBox();
            this.lblAkrNovinarID = new System.Windows.Forms.Label();
            this.gbAN = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedijskeKuce = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtPrezimeAN = new System.Windows.Forms.TextBox();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.txtImeAN = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(223, 75);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(78, 34);
            this.btnKreiraj.TabIndex = 11;
            this.btnKreiraj.Text = "Kreiraj!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtAkrNovinarID
            // 
            this.txtAkrNovinarID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAkrNovinarID.Location = new System.Drawing.Point(121, 78);
            this.txtAkrNovinarID.Name = "txtAkrNovinarID";
            this.txtAkrNovinarID.ReadOnly = true;
            this.txtAkrNovinarID.Size = new System.Drawing.Size(65, 29);
            this.txtAkrNovinarID.TabIndex = 10;
            // 
            // lblAkrNovinarID
            // 
            this.lblAkrNovinarID.AutoSize = true;
            this.lblAkrNovinarID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkrNovinarID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAkrNovinarID.Location = new System.Drawing.Point(65, 81);
            this.lblAkrNovinarID.Name = "lblAkrNovinarID";
            this.lblAkrNovinarID.Size = new System.Drawing.Size(31, 22);
            this.lblAkrNovinarID.TabIndex = 9;
            this.lblAkrNovinarID.Text = "ID:";
            // 
            // gbAN
            // 
            this.gbAN.Controls.Add(this.label1);
            this.gbAN.Controls.Add(this.cmbMedijskeKuce);
            this.gbAN.Controls.Add(this.txtTelefon);
            this.gbAN.Controls.Add(this.lblTelefon);
            this.gbAN.Controls.Add(this.txtEmail);
            this.gbAN.Controls.Add(this.lblEmail);
            this.gbAN.Controls.Add(this.txtJMBG);
            this.gbAN.Controls.Add(this.lblJMBG);
            this.gbAN.Controls.Add(this.btnSacuvaj);
            this.gbAN.Controls.Add(this.txtPrezimeAN);
            this.gbAN.Controls.Add(this.lblVlasnik);
            this.gbAN.Controls.Add(this.txtImeAN);
            this.gbAN.Controls.Add(this.lblIme);
            this.gbAN.Enabled = false;
            this.gbAN.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAN.Location = new System.Drawing.Point(34, 173);
            this.gbAN.Name = "gbAN";
            this.gbAN.Size = new System.Drawing.Size(576, 447);
            this.gbAN.TabIndex = 12;
            this.gbAN.TabStop = false;
            this.gbAN.Text = "Podaci o akreditovanom novinaru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medijska kuća:";
            // 
            // cmbMedijskeKuce
            // 
            this.cmbMedijskeKuce.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedijskeKuce.FormattingEnabled = true;
            this.cmbMedijskeKuce.Location = new System.Drawing.Point(299, 304);
            this.cmbMedijskeKuce.Name = "cmbMedijskeKuce";
            this.cmbMedijskeKuce.Size = new System.Drawing.Size(249, 30);
            this.cmbMedijskeKuce.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(299, 254);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(249, 29);
            this.txtTelefon.TabIndex = 19;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefon.Location = new System.Drawing.Point(20, 257);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(99, 22);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Broj telefona:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(299, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 29);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(20, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 22);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.Location = new System.Drawing.Point(299, 151);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(249, 29);
            this.txtJMBG.TabIndex = 15;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJMBG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJMBG.Location = new System.Drawing.Point(20, 155);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(56, 22);
            this.lblJMBG.TabIndex = 14;
            this.lblJMBG.Text = "JMBG:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacuvaj.Location = new System.Drawing.Point(204, 370);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 46);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj!";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtPrezimeAN
            // 
            this.txtPrezimeAN.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimeAN.Location = new System.Drawing.Point(299, 98);
            this.txtPrezimeAN.Name = "txtPrezimeAN";
            this.txtPrezimeAN.Size = new System.Drawing.Size(249, 29);
            this.txtPrezimeAN.TabIndex = 13;
            // 
            // lblVlasnik
            // 
            this.lblVlasnik.AutoSize = true;
            this.lblVlasnik.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlasnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVlasnik.Location = new System.Drawing.Point(20, 101);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(236, 22);
            this.lblVlasnik.TabIndex = 12;
            this.lblVlasnik.Text = "Prezime akreditovanog novinara:";
            // 
            // txtImeAN
            // 
            this.txtImeAN.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeAN.Location = new System.Drawing.Point(299, 46);
            this.txtImeAN.Name = "txtImeAN";
            this.txtImeAN.Size = new System.Drawing.Size(249, 29);
            this.txtImeAN.TabIndex = 11;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(20, 50);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(206, 22);
            this.lblIme.TabIndex = 10;
            this.lblIme.Text = "Ime akreditovanog novinara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 151);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmUnosAkreditovanogNovinara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(650, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAN);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtAkrNovinarID);
            this.Controls.Add(this.lblAkrNovinarID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUnosAkreditovanogNovinara";
            this.Text = "[Filmski festival \"Kulturiška\"] - Unos akreditovanog novinara";
            this.Load += new System.EventHandler(this.frmUnosAkreditovanogNovinara_Load);
            this.gbAN.ResumeLayout(false);
            this.gbAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtAkrNovinarID;
        private System.Windows.Forms.Label lblAkrNovinarID;
        private System.Windows.Forms.GroupBox gbAN;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtPrezimeAN;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.TextBox txtImeAN;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedijskeKuce;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}