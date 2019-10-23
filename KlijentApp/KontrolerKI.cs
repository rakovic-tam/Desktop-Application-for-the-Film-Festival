using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace KlijentApp
{
    public class KontrolerKI
    {
        static Komunikacija komunikacija;
        public static AngazovaniStudent astudent;
        static MedijskaKuca mk;
        static AkreditovaniNovinar an;
        static AngazovaniStudent ast;
        public static Projekcija projekcija;
        static Raspored raspored;

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if( komunikacija.poveziSeNaServer())
            {
                return "Angažovani student je povezan na server!";
            }
            else return "Angažovani student nije povezan na server!";
        }

        public static void kraj()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception)
            {


            }
        }

        internal bool pronadjiAngazovanogStudenta(TextBox txtKorisnickoIme, TextBox txtKorisnickaSifra)
        {
            astudent = new AngazovaniStudent();
            astudent.KorisnickoIme = txtKorisnickoIme.Text;
            astudent.KorisnickaSifra = txtKorisnickaSifra.Text;

            astudent.USLOVI = " KorisnickoIme='" + astudent.KorisnickoIme + "' and KorisnickaSifra='" + astudent.KorisnickaSifra + "'";
            
            astudent = komunikacija.PronadjiAngazovanogStudenta(astudent) as AngazovaniStudent;

            if (astudent == null)
            {
                MessageBox.Show("Na osnovu unetih vrednosti, sistem ne može da pronađe angažovanog studenta.");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno ste prijavljeni na sistem!");
                return true;
            }
        }

        internal void kreirajMedijskuKucu(TextBox txtMedijskaKucaID, Button btnKreiraj, GroupBox gbMK)
        {
            mk = komunikacija.kreirajMedijskuKucu() as MedijskaKuca;

            if (mk == null)
            {
                MessageBox.Show("Nemoguće je kreirati medijsku kuću!");
                btnKreiraj.Enabled = true;
                gbMK.Enabled = false;
            }
            else
            {
                txtMedijskaKucaID.Text = mk.MedijskaKucaID.ToString();
                btnKreiraj.Enabled = false;
                gbMK.Enabled = true;
            }
        }

        internal bool zapamtiMedijskuKucu(TextBox txtNazivMK, TextBox txtVlasnikMK)
        {
            mk.Naziv = txtNazivMK.Text;
            if (mk.Naziv == "")
            {
                MessageBox.Show("Morate uneti naziv medijske kuće!");
                txtNazivMK.Focus();
                return false;
            }

            mk.Vlasnik = txtVlasnikMK.Text;
            if (mk.Vlasnik == "")
            {
                MessageBox.Show("Morate uneti ime i prezime vlasnika medijske kuće!");
                txtVlasnikMK.Focus();
                return false;
            }

            Object rez = komunikacija.zapamtiMedijskuKucu(mk);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti novu medijsku kuću.");
                return false;
            }
            else
            {
                MessageBox.Show("Uneta medijska kuća je zapamćena.");
                return true;
            }

        }

        internal void ucitajMedijskeKuce(ComboBox cmbMedijskeKuce)
        {
            cmbMedijskeKuce.DataSource = komunikacija.ucitajSveMedijskeKuce();
        }

        internal void kreirajAkreditovanogNovinara(TextBox txtAkrNovinarID, Button btnKreiraj, GroupBox gbAN)
        {
            an = komunikacija.kreirajAkreditovanogNovinara() as AkreditovaniNovinar;

            if (an == null)
            {
                MessageBox.Show("Nemoguće je kreirati akreditovanog novinara!");
                btnKreiraj.Enabled = true;
                gbAN.Enabled = false;
            }
            else
            {
                txtAkrNovinarID.Text = an.AkreditovaniNovinarID.ToString();
                btnKreiraj.Enabled = false;
                gbAN.Enabled = true;
            }
        }

        internal bool zapamtiAkreditovanogNovinara(TextBox txtImeAN, TextBox txtPrezimeAN, TextBox txtJMBG, TextBox txtEmail, TextBox txtTelefon, ComboBox cmbMedijskeKuce)
        {
            an.Ime = txtImeAN.Text;
            if (an.Ime == "")
            {
                MessageBox.Show("Morate uneti ime akreditovanog novinara!");
                txtImeAN.Focus();
                return false;
            }

            an.Prezime = txtPrezimeAN.Text;
            if (an.Prezime == "")
            {
                MessageBox.Show("Morate uneti prezime akreditovanog novinara!");
                txtPrezimeAN.Focus();
                return false;
            }

            an.Jmbg = txtJMBG.Text;

            if (an.Jmbg.Length != 13)
            {
                MessageBox.Show("Matični broj akreditovanog novinara mora imati 13 cifara!");
                txtJMBG.Focus();
                return false;
            }

            if (an.Jmbg == "")
            {
                MessageBox.Show("Morate uneti matični broj akreditovanog novinara!");
                txtJMBG.Focus();
                return false;
            }

            an.Email = txtEmail.Text;
            if (an.Email == "")
            {
                MessageBox.Show("Morate uneti e-mail akreditovanog novinara!");
                txtEmail.Focus();
                return false;
            }

            an.BrojTelefona = txtTelefon.Text;
            if (an.BrojTelefona == "")
            {
                MessageBox.Show("Morate uneti broj telefona akreditovanog novinara!");
                txtTelefon.Focus();
                return false;
            }

            an.MedijskaKuca = cmbMedijskeKuce.SelectedItem as MedijskaKuca;
            if(an.MedijskaKuca == null)
            {
                MessageBox.Show("Morate izabrati medijsku kuću!");
                return false;
            }


            Object rez = komunikacija.zapamtiAkreditovanogNovinara(an);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti novinara.");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno je zapamćen akreditovani novinar.");
                return true;
            }

        }

        internal void pronadjiAkreditovaneNovinare(TextBox txtPretraga, DataGridView dgvPretraga)
        {
            an = new AkreditovaniNovinar();
            an.USLOVI = " Ime like '" + txtPretraga.Text + "%' or Prezime like '" + txtPretraga.Text + "%' or BrojTelefona like '" + txtPretraga.Text + "%'";

            List<AkreditovaniNovinar> lista = komunikacija.pronadjiAkreditovaneNovinare(an) as List<AkreditovaniNovinar>;
            dgvPretraga.DataSource = lista;
            dgvPretraga.Columns[3].Width = 190;
            dgvPretraga.Columns[4].Width = 80;
            dgvPretraga.Columns[5].Width = 160;

            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe akreditovane novinare!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Na osnovu unetih vrednosti sistem ne može da pronađe nijednog odgovarajućeg novinara!");
                return;
            }
            
        }

        internal bool ucitajAkreditovanogNovinara(DataGridView dgvPretraga)
        {
            try
            {
                an = dgvPretraga.CurrentRow.DataBoundItem as AkreditovaniNovinar;
                an = komunikacija.ucitajAkreditovanogNovinara(an) as AkreditovaniNovinar;
                if (an == null)
                {
                    MessageBox.Show("Sistem ne moze da pronađe podatke o konkretnom novinaru!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je pronašao podatke o akreditovanom novinaru koji je izabran.");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali akreditovanog novinara!");
                return false;
            }
        }

        internal void popuniDetalje(TextBox txtImeAN, TextBox txtPrezimeAN, TextBox txtJMBG, TextBox txtEmail, TextBox txtTelefon, ComboBox cmbMedijskeKuce)
        {
            cmbMedijskeKuce.DataSource = komunikacija.ucitajSveMedijskeKuce();
            txtImeAN.Text = an.Ime;
            txtPrezimeAN.Text = an.Prezime;
            txtJMBG.Text = an.Jmbg;
            txtEmail.Text = an.Email;
            txtTelefon.Text = an.BrojTelefona;
            cmbMedijskeKuce.Text = an.MedijskaKuca.ToString();
        }

        internal void kreirajAngazovanogStudenta(TextBox txtStudentID, Button btnKreiraj, GroupBox gbAS)
        {
            ast = komunikacija.kreirajAngazovanogStudenta() as AngazovaniStudent;

            if (ast == null)
            {
                MessageBox.Show("Nemoguće je kreirati angažovanog studenta!");
                btnKreiraj.Enabled = true;
                gbAS.Enabled = false;
            }
            else
            {
                txtStudentID.Text = ast.AngazovaniStudentID.ToString();
                btnKreiraj.Enabled = false;
                gbAS.Enabled = true;
            }
        }

        internal bool zapamtiAngazovanogStudenta(TextBox txtImeAS, TextBox txtPrezimeAS, TextBox txtJMBGAS, TextBox txtUsername, TextBox txtPassword)
        {
            ast.Ime = txtImeAS.Text;
            if (ast.Ime == "")
            {
                MessageBox.Show("Morate uneti ime angažovanog studenta!");
                txtImeAS.Focus();
                return false;
            }

            ast.Prezime = txtPrezimeAS.Text;
            if (ast.Prezime == "")
            {
                MessageBox.Show("Morate uneti prezime angažovanog studenta!");
                txtPrezimeAS.Focus();
                return false;
            }

            ast.Jmbg = txtJMBGAS.Text;

            if (ast.Jmbg.Length != 13)
            {
                MessageBox.Show("Matični broj angažovanog studenta mora imati 13 cifara!");
                txtJMBGAS.Focus();
                return false;
            }

            if (ast.Jmbg == "")
            {
                MessageBox.Show("Morate uneti matični broj angažovanog studenta!");
                txtJMBGAS.Focus();
                return false;
            }

            ast.KorisnickoIme = txtUsername.Text;
            if (ast.KorisnickoIme == "")
            {
                MessageBox.Show("Morate uneti korisničko ime angažovanog studenta!");
                txtUsername.Focus();
                return false;
            }

            ast.KorisnickaSifra = txtPassword.Text;
            if (ast.KorisnickaSifra == "")
            {
                MessageBox.Show("Morate uneti korisničku šifru angažovanog studenta!");
                txtPassword.Focus();
                return false;
            }

            Object rez = komunikacija.zapamtiAngazovanogStudenta(ast);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti studenta.");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno je zapamćen novi angažovani student.");
                return true;
            }

        }

        internal void ucitajSveAkreditovaneNovinare(ComboBox cmbAkrNovinari)
        {
            cmbAkrNovinari.DataSource = komunikacija.ucitajSveAkreditovaneNovinare();
        }

        internal void popuniPoljaAkrNovinar(TextBox txtMedijskaKuca, TextBox txtJMBG, TextBox txtEmail, TextBox txtTelefon, ComboBox cmbAkrNovinari, TextBox txtVreme)
        {
            an = cmbAkrNovinari.SelectedItem as AkreditovaniNovinar;
            txtMedijskaKuca.Text = an.MedijskaKuca.Naziv;
            txtJMBG.Text = an.Jmbg;
            txtEmail.Text = an.Email;
            txtTelefon.Text = an.BrojTelefona;
            txtVreme.Focus();
        }

        internal void ucitajProjekcije(ComboBox cmbProjekcije)
        {
            cmbProjekcije.DataSource = komunikacija.ucitajProjekcije();
        }

        internal void popuniPoljaProjekcija(TextBox txtSala, ComboBox cmbProjekcije)
        {
            projekcija = cmbProjekcije.SelectedItem as Projekcija;
            txtSala.Text = projekcija.Sala.ToString();
        }

        internal void obrisiAkreditovanogNovinara(DataGridView dgvAkrNovinariRaspored)
        {
            try
            {
                Raspored r = dgvAkrNovinariRaspored.CurrentRow.DataBoundItem as Raspored;
                if (r.Status == Status.Dodat) projekcija.ListaAkrNovinara.Remove(r);
                else r.Status = Status.Obrisan;
            }
            catch (Exception)
            {

                MessageBox.Show("Morate odabrati akreditovanog novinara za brisanje!");
            }
        }

        internal void kreirajRaspored(TextBox txtID, Button btnKreiraj, GroupBox gbProjekcija, DataGridView dgvAkrNovinariRaspored)
        {
            projekcija = komunikacija.kreirajRaspored() as Projekcija;

            if(projekcija == null)
            {
                MessageBox.Show("Nemoguće je kreirati raspored!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao raspored!");
                txtID.Text = projekcija.ProjekcijaID.ToString();
                btnKreiraj.Enabled = false;
                gbProjekcija.Enabled = true;
                dgvAkrNovinariRaspored.DataSource = projekcija.ListaAkrNovinara;
                dgvAkrNovinariRaspored.Columns[0].Width = 240;
                dgvAkrNovinariRaspored.Columns[1].Width = 110;
                dgvAkrNovinariRaspored.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvAkrNovinariRaspored.Columns[2].Width = 110;
                dgvAkrNovinariRaspored.Columns[3].Width = 110;
                dgvAkrNovinariRaspored.Columns[4].Visible = false;
            }
        }

        internal bool zapamtiRaspored(ComboBox cmbProjekcije)
        {
            projekcija = cmbProjekcije.SelectedItem as Projekcija;
            if(projekcija == null)
            {
                MessageBox.Show("Morate odabrati projekciju.");
                return false;
            }
           
            Object rez = komunikacija.zapamtiRaspored(projekcija);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti raspored.");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno je zapamćen novi raspored.");
                return true;
            }
        }

        internal bool dodajAkrNovinara(ComboBox cmbAkrNovinari, DataGridView dgvAkrNovinariRaspored, DateTimePicker dtpDatum, TextBox txtVreme)
        {
            Raspored r = new Raspored();
            r.Status = Status.Dodat;
            r.Projekcija = projekcija;
            r.AkreditovaniNovinar = cmbAkrNovinari.SelectedItem as AkreditovaniNovinar;

            if (r.AkreditovaniNovinar == null)
            {
                MessageBox.Show("Niste odabrali akreditovanog novinara!");
                return false;
            }

            String datum = dtpDatum.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            String vreme = txtVreme.Text;
            try
            {
                r.DatumIVreme = DateTime.ParseExact(datum + " " + vreme, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); 
            }
            catch (Exception)
            {
                MessageBox.Show("Datum nije u dobrom formatu!");
                return false;
            }

            r.AngazovaniStudent = astudent;

            projekcija.ListaAkrNovinara.Add(r);
            dgvAkrNovinariRaspored.DataSource = projekcija.ListaAkrNovinara;
            dgvAkrNovinariRaspored.Refresh();
            return true;
        }

        internal void pronadjiRasporede(TextBox txtFilter, DataGridView dgvPretragaRasporeda)
        {
            raspored = new Raspored();
            List<Raspored> lista = komunikacija.pronadjiRasporede(raspored) as List<Raspored>;
            projekcija = new Projekcija();
            projekcija.ListaAkrNovinara = new BindingList<Raspored>(lista);
            dgvPretragaRasporeda.DataSource = projekcija.ListaAkrNovinara;

            dgvPretragaRasporeda.Columns[0].Width = 240;
            dgvPretragaRasporeda.Columns[1].Width = 130;
            dgvPretragaRasporeda.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvPretragaRasporeda.Columns[2].Width = 130;
            dgvPretragaRasporeda.Columns[3].Width = 130;
            
            if (projekcija.ListaAkrNovinara == null)
            {
                MessageBox.Show("Sistem ne može da pronađe rasporede!");
                return;
            }
            if (projekcija.ListaAkrNovinara.Count == 0)
            {
                MessageBox.Show("Na osnovu unetih vrednosti sistem ne može da pronađe nijedan odgovarajući raspored.");
                return;
            }
        }

        internal bool ucitajRaspored(DataGridView dgvPretragaRasporeda)
        {
            try
            {
                raspored = dgvPretragaRasporeda.CurrentRow.DataBoundItem as Raspored;
                if (raspored == null)
                {
                    MessageBox.Show("Sistem ne može da pronađe podatke o konkretnom rasporedu.");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je pronašao podatke o izabranom rasporedu.");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali raspored!");
                return false;
            }
        }

        internal void popuniDetaljeORasporedu(ComboBox cmbProjekcije, TextBox txtSala, ComboBox cmbAkrNovinari, TextBox txtMedijskaKuca, TextBox txtJMBG, TextBox txtEmail, TextBox txtTelefon, DataGridView dgvAkrNovinariRaspored, DateTimePicker dtpDatum, TextBox txtVreme)
        {
            cmbProjekcije.DataSource = komunikacija.ucitajProjekcije();
            cmbAkrNovinari.DataSource = komunikacija.ucitajSveAkreditovaneNovinare();
            

            cmbProjekcije.Text = raspored.Projekcija.ToString();
            txtSala.Text = raspored.Projekcija.Sala.ToString();

            cmbAkrNovinari.Text = raspored.AkreditovaniNovinar.ToString();
            txtMedijskaKuca.Text = raspored.AkreditovaniNovinar.MedijskaKuca.ToString();
            txtJMBG.Text = raspored.AkreditovaniNovinar.Jmbg;
            txtEmail.Text = raspored.AkreditovaniNovinar.Email;
            txtTelefon.Text = raspored.AkreditovaniNovinar.BrojTelefona;

            string datumcic = raspored.DatumIVreme.ToShortDateString();

            DateTime datum = Convert.ToDateTime(datumcic);
            dtpDatum.Value = datum;
            dtpDatum.CustomFormat = "dd / MM / yyyy";
            txtVreme.Text = raspored.DatumIVreme.ToString("HH:mm");
        }

        internal bool izmeniAkrNovinara(ComboBox cmbProjekcije, ComboBox cmbAkrNovinari, DataGridView DgvRasporedi, DateTimePicker dtpDatum, TextBox txtVreme)
        {
            raspored.StariIDProjekcije = raspored.Projekcija.ProjekcijaID;
            raspored.StariIDAkreditovanogNovinara = raspored.AkreditovaniNovinar.AkreditovaniNovinarID;
            raspored.USLOVI = "ProjekcijaID=" + raspored.StariIDProjekcije + " and AkreditovaniNovinarID=" + raspored.StariIDAkreditovanogNovinara;
            raspored.Status = Status.Izmenjen;
            raspored.Projekcija = cmbProjekcije.SelectedItem as Projekcija;
            raspored.AkreditovaniNovinar = cmbAkrNovinari.SelectedItem as AkreditovaniNovinar;

            if (raspored.AkreditovaniNovinar == null)
            {
                MessageBox.Show("Niste odabrali akreditovanog novinara!");
                return false;
            }

            String datum = dtpDatum.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            String vreme = txtVreme.Text;
            try
            {
                raspored.DatumIVreme = DateTime.ParseExact(datum + " " + vreme, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum nije u dobrom formatu!");
                return false;
            }

            raspored.AngazovaniStudent = astudent;
            MessageBox.Show("Sistem je uspešno izmenio raspored.");
            DgvRasporedi.Refresh();
            return true;
        }

        internal bool dodajAkrNovinaraKodIzmene(ComboBox cmbProjekcije, ComboBox cmbAkrNovinari, DataGridView dgvAkrNovinariRaspored, DateTimePicker dtpDatum, TextBox txtVreme)
        {
            raspored.Status = Status.Dodat;
            Raspored r = new Raspored();
            projekcija = cmbProjekcije.SelectedItem as Projekcija;
            r.Projekcija = projekcija;
            r.AkreditovaniNovinar = cmbAkrNovinari.SelectedItem as AkreditovaniNovinar;

            if (r.Projekcija == null)
            {
                MessageBox.Show("Niste odabrali projekciju!");
                return false;
            }

            if (r.AkreditovaniNovinar == null)
            {
                MessageBox.Show("Niste odabrali akreditovanog novinara!");
                return false;
            }

            String datum = dtpDatum.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            String vreme = txtVreme.Text;
            try
            {
                r.DatumIVreme = DateTime.ParseExact(datum + " " + vreme, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum nije u dobrom formatu!");
                return false;
            }

            r.AngazovaniStudent = astudent;

            r.Status = Status.Dodat;
            projekcija.ListaAkrNovinara.Add(r);
            dgvAkrNovinariRaspored.DataSource = projekcija.ListaAkrNovinara;
            dgvAkrNovinariRaspored.Columns[0].Width = 240;
            dgvAkrNovinariRaspored.Columns[1].Width = 110;
            dgvAkrNovinariRaspored.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvAkrNovinariRaspored.Columns[2].Width = 110;
            dgvAkrNovinariRaspored.Columns[3].Width = 110;
            dgvAkrNovinariRaspored.Columns[4].Visible = false;
            dgvAkrNovinariRaspored.Refresh();
            return true;
        }

        internal bool brisanjeRasporeda(DataGridView dgvPretragaRasporeda)
        {
            Raspored rasp = dgvPretragaRasporeda.CurrentRow.DataBoundItem as Raspored;
            rasp.Status = Status.Obrisan;
            MessageBox.Show("Sistem je uspešno obrisao raspored.");
            return true;
        }

        internal void vratiRasporedeZaUslov(TextBox txtPretragaRasporeda, DataGridView dgvPretragaRasporeda)
        {
            string uslov = txtPretragaRasporeda.Text;

            List<Raspored> lista = komunikacija.vratiRasporedeZaUslov(uslov) as List<Raspored>;

            dgvPretragaRasporeda.DataSource = lista;
            dgvPretragaRasporeda.Columns[0].Width = 240;
            dgvPretragaRasporeda.Columns[1].Width = 130;
            dgvPretragaRasporeda.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvPretragaRasporeda.Columns[2].Width = 130;
            dgvPretragaRasporeda.Columns[3].Width = 130;

            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe rasporede!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Na osnovu unetih vrednosti sistem ne može da pronađe nijedan odgovarajući raspored.");
                return;
            }

        }

        internal bool sacuvajRasporede(DataGridView dgvPretragaRasporeda)
        {
            Object rez = komunikacija.zapamtiRaspored(projekcija);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da sačuva raspored.");
                return false;
            }
            else
            {
                MessageBox.Show("Uspešno je sačuvan raspored.");
                return true;
            }
        }

        internal void bojeGridaPretragaRasporeda(DataGridView dgvPretragaRasporeda)
        {
            for (int i=0; i < dgvPretragaRasporeda.Rows.Count; i++)
            {
                string status = dgvPretragaRasporeda.Rows[i].Cells[4].Value.ToString();
                if(status == "Obrisan")
                {
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.BackColor = Color.DimGray;
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                if (status == "Izmenjen")
                {
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                if (status == "Dodat")
                {
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                    dgvPretragaRasporeda.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
