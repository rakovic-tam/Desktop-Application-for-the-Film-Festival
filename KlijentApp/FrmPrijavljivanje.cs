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
    public partial class FrmPrijavljivanje : Form
    {
        KontrolerKI kontroler = new KontrolerKI();   
        public FrmPrijavljivanje()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.poveziSeNaServer();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.kraj();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (kontroler.pronadjiAngazovanogStudenta(txtKorisnickoIme, txtKorisnickaSifra)) {
                new FrmGlavniMeni().ShowDialog();
                this.Hide();
            }
        }

        private void btnOkice_Click(object sender, EventArgs e)
        {
            txtKorisnickaSifra.UseSystemPasswordChar = !txtKorisnickaSifra.UseSystemPasswordChar;
        }
    }
}
