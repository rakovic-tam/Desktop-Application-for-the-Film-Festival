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
    public partial class FrmUnosMedijskeKuce : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmUnosMedijskeKuce()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmUnosMedijskeKuce_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kontroler.kreirajMedijskuKucu(txtMedijskaKucaID, btnKreiraj, gbMK);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(kontroler.zapamtiMedijskuKucu(txtNazivMK, txtVlasnikMK)) {
                this.Close();
            }    
        }
    }
}
