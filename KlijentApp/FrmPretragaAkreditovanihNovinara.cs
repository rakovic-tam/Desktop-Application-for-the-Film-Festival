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
    public partial class FrmPretragaAkreditovanihNovinara : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmPretragaAkreditovanihNovinara()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
        }

        private void FrmPretragaAkreditovanihNovinara_Load(object sender, EventArgs e)
        {
            kontroler.pronadjiAkreditovaneNovinare(txtPretraga, dgvPretraga);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            kontroler.pronadjiAkreditovaneNovinare(txtPretraga, dgvPretraga);
        }

        private void dgvPretraga_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kontroler.ucitajAkreditovanogNovinara(dgvPretraga)) {
                new FrmDetaljiAkreditovanogNovinara().ShowDialog();
                txtPretraga_TextChanged(sender, e);
            }
        }

        private void lblPretraga_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
