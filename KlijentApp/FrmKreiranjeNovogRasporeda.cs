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
    public partial class FrmKreiranjeNovogRasporeda : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmKreiranjeNovogRasporeda()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmKreiranjeNovogRasporeda_Load(object sender, EventArgs e)
        {
            dgvAkrNovinariRaspored.Refresh();
            kontroler.ucitajProjekcije(cmbProjekcije);
            cmbProjekcije.Text = "Izaberite!";
        }

        private void cmbProjekcije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kontroler.popuniPoljaProjekcija(txtSala, cmbProjekcije);
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kontroler.kreirajRaspored(txtID, btnKreiraj, gbProjekcija, dgvAkrNovinariRaspored);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kontroler.zapamtiRaspored(cmbProjekcije)) this.Close();
        }

        private void btnDodajAN_Click(object sender, EventArgs e)
        {
            new FrmDodajAkrNovinara(kontroler, dgvAkrNovinariRaspored).ShowDialog();
            btnSacuvaj.Enabled = true;
            dgvAkrNovinariRaspored.Refresh();
        }

        private void btnObrisiAN_Click(object sender, EventArgs e)
        {
            kontroler.obrisiAkreditovanogNovinara(dgvAkrNovinariRaspored);
        }
    }
}
