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
    public partial class frmUnosAkreditovanogNovinara : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public frmUnosAkreditovanogNovinara()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void frmUnosAkreditovanogNovinara_Load(object sender, EventArgs e)
        {
            kontroler.ucitajMedijskeKuce(cmbMedijskeKuce);
            cmbMedijskeKuce.Text = "Izaberite!";
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kontroler.kreirajAkreditovanogNovinara(txtAkrNovinarID, btnKreiraj, gbAN);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kontroler.zapamtiAkreditovanogNovinara(txtImeAN, txtPrezimeAN, txtJMBG, txtEmail, txtTelefon, cmbMedijskeKuce))
            {
                this.Close();
            }
        }
    }
}
