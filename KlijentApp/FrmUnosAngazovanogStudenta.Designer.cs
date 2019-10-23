namespace KlijentApp
{
    partial class FrmUnosAngazovanogStudenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosAngazovanogStudenta));
            this.gbAS = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtJMBGAS = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtPrezimeAS = new System.Windows.Forms.TextBox();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.txtImeAS = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStdID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAS
            // 
            this.gbAS.Controls.Add(this.txtPassword);
            this.gbAS.Controls.Add(this.lblTelefon);
            this.gbAS.Controls.Add(this.txtUsername);
            this.gbAS.Controls.Add(this.lblEmail);
            this.gbAS.Controls.Add(this.txtJMBGAS);
            this.gbAS.Controls.Add(this.lblJMBG);
            this.gbAS.Controls.Add(this.btnSacuvaj);
            this.gbAS.Controls.Add(this.txtPrezimeAS);
            this.gbAS.Controls.Add(this.lblVlasnik);
            this.gbAS.Controls.Add(this.txtImeAS);
            this.gbAS.Controls.Add(this.lblIme);
            this.gbAS.Enabled = false;
            this.gbAS.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAS.Location = new System.Drawing.Point(36, 149);
            this.gbAS.Name = "gbAS";
            this.gbAS.Size = new System.Drawing.Size(576, 374);
            this.gbAS.TabIndex = 16;
            this.gbAS.TabStop = false;
            this.gbAS.Text = "Podaci o angažovanom studentu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(299, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 29);
            this.txtPassword.TabIndex = 19;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefon.Location = new System.Drawing.Point(20, 257);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(119, 22);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Korisnička šifra:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(299, 203);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 29);
            this.txtUsername.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(20, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 22);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Korisničko ime:";
            // 
            // txtJMBGAS
            // 
            this.txtJMBGAS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBGAS.Location = new System.Drawing.Point(299, 151);
            this.txtJMBGAS.Name = "txtJMBGAS";
            this.txtJMBGAS.Size = new System.Drawing.Size(249, 29);
            this.txtJMBGAS.TabIndex = 15;
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
            this.btnSacuvaj.Location = new System.Drawing.Point(204, 305);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 46);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj!";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtPrezimeAS
            // 
            this.txtPrezimeAS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimeAS.Location = new System.Drawing.Point(299, 98);
            this.txtPrezimeAS.Name = "txtPrezimeAS";
            this.txtPrezimeAS.Size = new System.Drawing.Size(249, 29);
            this.txtPrezimeAS.TabIndex = 13;
            // 
            // lblVlasnik
            // 
            this.lblVlasnik.AutoSize = true;
            this.lblVlasnik.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlasnik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVlasnik.Location = new System.Drawing.Point(20, 101);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(228, 22);
            this.lblVlasnik.TabIndex = 12;
            this.lblVlasnik.Text = "Prezime angažovanog studenta:";
            // 
            // txtImeAS
            // 
            this.txtImeAS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeAS.Location = new System.Drawing.Point(299, 46);
            this.txtImeAS.Name = "txtImeAS";
            this.txtImeAS.Size = new System.Drawing.Size(249, 29);
            this.txtImeAS.TabIndex = 11;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(20, 50);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(198, 22);
            this.lblIme.TabIndex = 10;
            this.lblIme.Text = "Ime angažovanog studenta:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(240, 59);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(78, 34);
            this.btnKreiraj.TabIndex = 15;
            this.btnKreiraj.Text = "Kreiraj!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(138, 62);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(65, 29);
            this.txtStudentID.TabIndex = 14;
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStdID.Location = new System.Drawing.Point(82, 65);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(31, 22);
            this.lblStdID.TabIndex = 13;
            this.lblStdID.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 127);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUnosAngazovanogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(652, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAS);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStdID);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUnosAngazovanogStudenta";
            this.Text = "[Filmski festival \"Kulturiška\"] - Unos angažovanog studenta";
            this.Load += new System.EventHandler(this.FrmUnosAngazovanogStudenta_Load);
            this.gbAS.ResumeLayout(false);
            this.gbAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAS;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtJMBGAS;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtPrezimeAS;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.TextBox txtImeAS;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}