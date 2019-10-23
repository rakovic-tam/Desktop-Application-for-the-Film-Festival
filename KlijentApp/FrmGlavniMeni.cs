using Domen;
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
    public partial class FrmGlavniMeni : Form
    {
        KontrolerKI kontroler = new KontrolerKI();
        public FrmGlavniMeni()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 0, 25);
            glavniMeni.ForeColor = Color.White;
            glavniMeni.Renderer = new ToolStripProfessionalRenderer(new GlavniMeniDizajn());
        }

        private void FrmGlavniMeni_Load(object sender, EventArgs e)
        {
            lblAngazovaniStudent.Text = KontrolerKI.astudent.ToString();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosMedijskeKuce().ShowDialog();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmUnosAkreditovanogNovinara().ShowDialog();
        }

        private void izmenaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaAkreditovanihNovinara().ShowDialog();
        }

        private void angažovaniStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosAngazovanogStudenta().ShowDialog();
        }

        private void kreiranjeNovogRasporedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmKreiranjeNovogRasporeda().ShowDialog();
        }

        private void pretraživanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaRasporeda().ShowDialog();
        }
    }
}
