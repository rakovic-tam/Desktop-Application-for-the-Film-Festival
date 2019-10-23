using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public partial class FrmDodajAkrNovinara : Form
    {
        KontrolerKI kontroler;

        public DataGridView Dgv { get; }

        public FrmDodajAkrNovinara(KontrolerKI kontroler, DataGridView dgv)
        {
            this.kontroler = kontroler;
            Dgv = dgv;
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmDodajAkrNovinara_Load(object sender, EventArgs e)
        {
            kontroler.ucitajSveAkreditovaneNovinare(cmbAkrNovinari);
            cmbAkrNovinari.Text = "Izaberite!";
            dtpDatum.CustomFormat = "dd / MM / yyyy";
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (kontroler.dodajAkrNovinara(cmbAkrNovinari, Dgv,dtpDatum, txtVreme)) this.Close();
        }

        private void cmbAkrNovinari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kontroler.popuniPoljaAkrNovinar(txtMedijskaKuca, txtJMBG, txtEmail, txtTelefon, cmbAkrNovinari, txtVreme);
            }
        }
    }
}
