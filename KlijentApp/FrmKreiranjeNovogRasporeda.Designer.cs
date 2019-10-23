namespace KlijentApp
{
    partial class FrmKreiranjeNovogRasporeda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreiranjeNovogRasporeda));
            this.gbProjekcija = new System.Windows.Forms.GroupBox();
            this.btnObrisiAN = new System.Windows.Forms.Button();
            this.btnDodajAN = new System.Windows.Forms.Button();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjekcije = new System.Windows.Forms.ComboBox();
            this.lblProjekcija = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAkrNovinarID = new System.Windows.Forms.Label();
            this.dgvAkrNovinariRaspored = new System.Windows.Forms.DataGridView();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gbProjekcija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkrNovinariRaspored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProjekcija
            // 
            this.gbProjekcija.Controls.Add(this.btnObrisiAN);
            this.gbProjekcija.Controls.Add(this.btnDodajAN);
            this.gbProjekcija.Controls.Add(this.txtSala);
            this.gbProjekcija.Controls.Add(this.label1);
            this.gbProjekcija.Controls.Add(this.cmbProjekcije);
            this.gbProjekcija.Controls.Add(this.lblProjekcija);
            this.gbProjekcija.Enabled = false;
            this.gbProjekcija.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProjekcija.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbProjekcija.Location = new System.Drawing.Point(33, 88);
            this.gbProjekcija.Name = "gbProjekcija";
            this.gbProjekcija.Size = new System.Drawing.Size(740, 225);
            this.gbProjekcija.TabIndex = 13;
            this.gbProjekcija.TabStop = false;
            this.gbProjekcija.Text = "Podaci o projekciji";
            // 
            // btnObrisiAN
            // 
            this.btnObrisiAN.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnObrisiAN.Location = new System.Drawing.Point(402, 148);
            this.btnObrisiAN.Name = "btnObrisiAN";
            this.btnObrisiAN.Size = new System.Drawing.Size(300, 48);
            this.btnObrisiAN.TabIndex = 32;
            this.btnObrisiAN.Text = "Obriši akreditovanog novinara!";
            this.btnObrisiAN.UseVisualStyleBackColor = true;
            this.btnObrisiAN.Click += new System.EventHandler(this.btnObrisiAN_Click);
            // 
            // btnDodajAN
            // 
            this.btnDodajAN.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajAN.Location = new System.Drawing.Point(66, 148);
            this.btnDodajAN.Name = "btnDodajAN";
            this.btnDodajAN.Size = new System.Drawing.Size(300, 48);
            this.btnDodajAN.TabIndex = 31;
            this.btnDodajAN.Text = "Dodaj akreditovanog novinara!";
            this.btnDodajAN.UseVisualStyleBackColor = true;
            this.btnDodajAN.Click += new System.EventHandler(this.btnDodajAN_Click);
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.Location = new System.Drawing.Point(238, 94);
            this.txtSala.Name = "txtSala";
            this.txtSala.ReadOnly = true;
            this.txtSala.Size = new System.Drawing.Size(57, 29);
            this.txtSala.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sala:";
            // 
            // cmbProjekcije
            // 
            this.cmbProjekcije.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjekcije.FormattingEnabled = true;
            this.cmbProjekcije.Location = new System.Drawing.Point(238, 51);
            this.cmbProjekcije.Name = "cmbProjekcije";
            this.cmbProjekcije.Size = new System.Drawing.Size(464, 30);
            this.cmbProjekcije.TabIndex = 22;
            this.cmbProjekcije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProjekcije_KeyDown);
            // 
            // lblProjekcija
            // 
            this.lblProjekcija.AutoSize = true;
            this.lblProjekcija.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjekcija.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjekcija.Location = new System.Drawing.Point(31, 54);
            this.lblProjekcija.Name = "lblProjekcija";
            this.lblProjekcija.Size = new System.Drawing.Size(124, 22);
            this.lblProjekcija.TabIndex = 18;
            this.lblProjekcija.Text = "Naziv projekcije:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSacuvaj.Location = new System.Drawing.Point(632, 452);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(134, 73);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj raspored!";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(184, 25);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(162, 32);
            this.btnKreiraj.TabIndex = 34;
            this.btnKreiraj.Text = "Kreiraj raspored!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(89, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(65, 29);
            this.txtID.TabIndex = 33;
            // 
            // lblAkrNovinarID
            // 
            this.lblAkrNovinarID.AutoSize = true;
            this.lblAkrNovinarID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkrNovinarID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAkrNovinarID.Location = new System.Drawing.Point(33, 30);
            this.lblAkrNovinarID.Name = "lblAkrNovinarID";
            this.lblAkrNovinarID.Size = new System.Drawing.Size(31, 22);
            this.lblAkrNovinarID.TabIndex = 32;
            this.lblAkrNovinarID.Text = "ID:";
            // 
            // dgvAkrNovinariRaspored
            // 
            this.dgvAkrNovinariRaspored.AllowUserToAddRows = false;
            this.dgvAkrNovinariRaspored.AllowUserToResizeColumns = false;
            this.dgvAkrNovinariRaspored.AllowUserToResizeRows = false;
            this.dgvAkrNovinariRaspored.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAkrNovinariRaspored.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAkrNovinariRaspored.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAkrNovinariRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAkrNovinariRaspored.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAkrNovinariRaspored.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAkrNovinariRaspored.Location = new System.Drawing.Point(31, 358);
            this.dgvAkrNovinariRaspored.Name = "dgvAkrNovinariRaspored";
            this.dgvAkrNovinariRaspored.ReadOnly = true;
            this.dgvAkrNovinariRaspored.RowHeadersVisible = false;
            this.dgvAkrNovinariRaspored.Size = new System.Drawing.Size(577, 259);
            this.dgvAkrNovinariRaspored.TabIndex = 35;
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrikaz.Location = new System.Drawing.Point(29, 325);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(359, 23);
            this.lblPrikaz.TabIndex = 31;
            this.lblPrikaz.Text = "Prikaz akreditovanih novinara za izabranu projekciju:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 154);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(975, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 80);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(901, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 74);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(880, 535);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(227, 100);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(784, 354);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(276, 231);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(791, 243);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(124, 105);
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // FrmKreiranjeNovogRasporeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1110, 646);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrikaz);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dgvAkrNovinariRaspored);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAkrNovinarID);
            this.Controls.Add(this.gbProjekcija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmKreiranjeNovogRasporeda";
            this.Text = "[Filmski festival \"Kulturiška\"] - Kreiranje novog rasporeda";
            this.Load += new System.EventHandler(this.FrmKreiranjeNovogRasporeda_Load);
            this.gbProjekcija.ResumeLayout(false);
            this.gbProjekcija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkrNovinariRaspored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProjekcija;
        private System.Windows.Forms.ComboBox cmbProjekcije;
        private System.Windows.Forms.Label lblProjekcija;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAkrNovinarID;
        private System.Windows.Forms.DataGridView dgvAkrNovinariRaspored;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Button btnObrisiAN;
        private System.Windows.Forms.Button btnDodajAN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}