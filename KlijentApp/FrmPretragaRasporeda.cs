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
    public partial class FrmPretragaRasporeda : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmPretragaRasporeda()
        {
            InitializeComponent();
            dgvPretragaRasporeda.Refresh();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmPretragaRasporeda_Load(object sender, EventArgs e)
        {
            kontroler.vratiRasporedeZaUslov(txtPretragaRasporeda, dgvPretragaRasporeda);   
        }

        private void txtPretragaRasporeda_TextChanged(object sender, EventArgs e)
        {
            kontroler.vratiRasporedeZaUslov(txtPretragaRasporeda, dgvPretragaRasporeda);
        }

        private void dgvPretragaRasporeda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kontroler.ucitajRaspored(dgvPretragaRasporeda)) new FrmIzmenaRasporeda(kontroler, dgvPretragaRasporeda).ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kontroler.ucitajRaspored(dgvPretragaRasporeda)) new FrmIzmenaRasporeda(kontroler, dgvPretragaRasporeda).ShowDialog();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kontroler.sacuvajRasporede(dgvPretragaRasporeda);
        }

        private void btnObrisiRaspored_Click(object sender, EventArgs e)
        {
            kontroler.brisanjeRasporeda(dgvPretragaRasporeda);
            dgvPretragaRasporeda.Refresh();
            kontroler.bojeGridaPretragaRasporeda(dgvPretragaRasporeda);
        }
    }
}
