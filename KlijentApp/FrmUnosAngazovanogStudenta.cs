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
    public partial class FrmUnosAngazovanogStudenta : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmUnosAngazovanogStudenta()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmUnosAngazovanogStudenta_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kontroler.kreirajAngazovanogStudenta(txtStudentID, btnKreiraj, gbAS);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kontroler.zapamtiAngazovanogStudenta(txtImeAS, txtPrezimeAS, txtJMBGAS, txtUsername, txtPassword))
            {
                this.Close();
            }
        }
    }
}
