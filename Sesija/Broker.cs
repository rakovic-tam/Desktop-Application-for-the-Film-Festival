using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        SqlCommand komanda;
        SqlConnection konekcija;
        SqlTransaction transakcija;
        SqlDataReader citac;

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=tamara\sqlexpress;Initial Catalog=FestivalKulturiska;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Ne može da se uspostavi konekcija na bazu!");
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {

                MessageBox.Show("Ne može da se uspostavi transakcija na bazi!");
                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne može da potvrdi transakciju!");
                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne može da poništi transakciju!");
                throw;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistem ne može da zatvori konekciju!");
                throw;
            }
        }


        public void insert(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Insert into "+odo.NazivTabele+" "+odo.Insert;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void updateJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Update " + odo.NazivTabele + " set " + odo.Update+" where "+odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void update2(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Update " + odo.NazivTabele + " set " + odo.Update2 + " where " + odo.UslovOpsti;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteJedan(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Delete from " + odo.NazivTabele + " where " + odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteVise(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Delete from " + odo.NazivTabele + " where " + odo.UslovOpsti;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "Select * from " + odo.NazivTabele;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                   lista.Add( odo.procitajRed(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public OpstiDomenskiObjekat vratiJedanZaOpstiUslov(OpstiDomenskiObjekat odo)
        {

            try
            {
                komanda.CommandText = "Select * from " + odo.NazivTabele + " where " + odo.UslovOpsti;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);

            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaUslovOpsti(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "Select * from " + odo.NazivTabele+" where "+odo.UslovOpsti;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.procitajRed(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public OpstiDomenskiObjekat vratiJedanZaID(OpstiDomenskiObjekat odo)
        {
          
            try
            {
                komanda.CommandText = "Select * from " + odo.NazivTabele+" where "+odo.UslovID;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.procitajRed(tabela.Rows[0]);               
              
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "Select max("+odo.ID+") from "+odo.NazivTabele;
                try
                {
                    return Convert.ToInt32(komanda.ExecuteScalar())+1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Raspored> vratiRasporedeZaUslov(string uslov)
        {
            List<Raspored> lista = new List<Raspored>();
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from Raspored r inner join Projekcija p on p.ProjekcijaID=r.ProjekcijaID inner join  Film f on p.FilmID=f.FilmID inner join AkreditovaniNovinar an on an.AkreditovaniNovinarID=r.AkreditovaniNovinarID inner join MedijskaKuca mk on mk.MedijskaKucaiD=an.MedijskaKucaiD inner join AngazovaniStudent a on a.AngazovaniStudentID=r.AngazovaniStudentID where p.NazivBioskopa like '" + uslov + "%' or an.Ime like'" + uslov + "%' or an.Prezime like '" + uslov + "%' or f.Naziv like '" + uslov + "%'";
                SqlDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    Raspored r = new Raspored();
                    r.Projekcija = new Projekcija();
                    r.Projekcija.ProjekcijaID = citac.GetInt32(0);
                    r.Projekcija.NazivBioskopa = citac["NazivBioskopa"].ToString();
                    r.Projekcija.Sala = Convert.ToInt32(citac["Sala"]);

                    r.Projekcija.Film = new Film();
                    r.Projekcija.Film.FilmID = Convert.ToInt32(citac["FilmID"]);
                    r.Projekcija.Film.Naziv = citac.GetString(9);
                    r.Projekcija.Film.Zanr = citac["Zanr"].ToString();

                    r.AkreditovaniNovinar = new AkreditovaniNovinar();
                    r.AkreditovaniNovinar.AkreditovaniNovinarID = citac.GetInt32(1);
                    r.AkreditovaniNovinar.Ime = citac["Ime"].ToString();
                    r.AkreditovaniNovinar.Prezime = citac["Prezime"].ToString();
                    r.AkreditovaniNovinar.Jmbg = citac["JMBG"].ToString();
                    r.AkreditovaniNovinar.Email = citac["Email"].ToString();
                    r.AkreditovaniNovinar.BrojTelefona = citac["BrojTelefona"].ToString();

                    r.AkreditovaniNovinar.MedijskaKuca = new MedijskaKuca();
                    r.AkreditovaniNovinar.MedijskaKuca.MedijskaKucaID = Convert.ToInt32(citac["MedijskaKucaID"]);
                    r.AkreditovaniNovinar.MedijskaKuca.Naziv = citac.GetString(19);
                    r.AkreditovaniNovinar.MedijskaKuca.Vlasnik = citac["Vlasnik"].ToString();

                    r.DatumIVreme = citac.GetDateTime(2);

                    r.AngazovaniStudent = new AngazovaniStudent();
                    r.AngazovaniStudent.AngazovaniStudentID = citac.GetInt32(21);
                    r.AngazovaniStudent.Ime = citac.GetString(22);
                    r.AngazovaniStudent.Prezime = citac.GetString(23);
                    r.AngazovaniStudent.Jmbg = citac.GetString(24);
                    r.AngazovaniStudent.KorisnickoIme = citac.GetString(25);
                    r.AngazovaniStudent.KorisnickaSifra = citac.GetString(26);

                    lista.Add(r);
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
            finally { if (konekcija != null) konekcija.Close(); }
        }

    }
}
