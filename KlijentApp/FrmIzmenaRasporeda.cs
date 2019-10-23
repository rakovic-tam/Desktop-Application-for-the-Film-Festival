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
    public partial class FrmIzmenaRasporeda : Form
    {
        KontrolerKI kontroler;
        public DataGridView DgvRasporedi { get; }
        public FrmIzmenaRasporeda(KontrolerKI kontroler, DataGridView dgvPretragaRasporeda)
        {
            this.kontroler = kontroler;
            DgvRasporedi = dgvPretragaRasporeda;
            InitializeComponent();
            cmbAkrNovinari.Text = "Izaberite!";
            this.BackColor = Color.FromArgb(51, 0, 25);
        }
        

        private void FrmDetaljiRasporeda_Load(object sender, EventArgs e)
        {
            kontroler.popuniDetaljeORasporedu(cmbProjekcije, txtSala, cmbAkrNovinari, txtMedijskaKuca, txtJMBG, txtEmail, txtTelefon, dgvAkrNovinariRaspored, dtpDatum, txtVreme);
        }

        private void cmbAkrNovinari_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontroler.popuniPoljaAkrNovinar(txtMedijskaKuca, txtJMBG, txtEmail, txtTelefon, cmbAkrNovinari, txtVreme);
        }

        private void btnDodajAN_Click(object sender, EventArgs e)
        {
            kontroler.dodajAkrNovinaraKodIzmene(cmbProjekcije, cmbAkrNovinari, dgvAkrNovinariRaspored, dtpDatum, txtVreme);
        }

        private void btnIzmeniNovinara_Click(object sender, EventArgs e)
        {
            kontroler.izmeniAkrNovinara(cmbProjekcije, cmbAkrNovinari, DgvRasporedi, dtpDatum, txtVreme);
            kontroler.bojeGridaPretragaRasporeda(DgvRasporedi);
            this.Close();
        }

        private void btnObrisiAkrNov_Click(object sender, EventArgs e)
        {
            kontroler.obrisiAkreditovanogNovinara(dgvAkrNovinariRaspored);
        }

        private void btnZavrsiIzmene_Click(object sender, EventArgs e)
        {
            this.Close();
            DgvRasporedi.Refresh();
            kontroler.bojeGridaPretragaRasporeda(DgvRasporedi);
        }
    }
}
