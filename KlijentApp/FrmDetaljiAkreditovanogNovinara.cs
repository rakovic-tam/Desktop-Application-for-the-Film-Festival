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
    public partial class FrmDetaljiAkreditovanogNovinara : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmDetaljiAkreditovanogNovinara()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        

        private void FrmDetaljiAkreditovanogNovinara_Load(object sender, EventArgs e)
        {
            kontroler.popuniDetalje(txtImeAN, txtPrezimeAN, txtJMBG, txtEmail, txtTelefon, cmbMedijskeKuce);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kontroler.zapamtiAkreditovanogNovinara(txtImeAN, txtPrezimeAN, txtJMBG, txtEmail, txtTelefon, cmbMedijskeKuce))
            {
                this.Close();
            }
        }
    }
}
