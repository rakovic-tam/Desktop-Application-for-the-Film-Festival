using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace Domen
{
    [Serializable]
    public class AngazovaniStudent:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }
        int angazovaniStudentID;
        string ime;
        string prezime;
        string jmbg;
        string korisnickoIme;
        string korisnickaSifra;

        public int AngazovaniStudentID { get => angazovaniStudentID; set => angazovaniStudentID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string KorisnickaSifra { get => korisnickaSifra; set => korisnickaSifra = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "AngazovaniStudent";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "AngazovaniStudentID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " AngazovaniStudentID=" + AngazovaniStudentID;
            }
        }

        public string USLOVI;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
               return USLOVI;
            }
        }
        
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(AngazovaniStudentID) values (" + AngazovaniStudentID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='" + Ime + "', Prezime='" + Prezime + "',JMBG='" + Jmbg + "', KorisnickoIme='" + KorisnickoIme + "', KorisnickaSifra='" + KorisnickaSifra + "' ";
            }
        }

        [Browsable(false)]
        public string Update2
        {
            get
            {
                return "Jej";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            AngazovaniStudent s = new AngazovaniStudent();
            s.AngazovaniStudentID= Convert.ToInt32(red["AngazovaniStudentID"]);
            s.Ime = red["Ime"].ToString();
            s.Prezime = red["Prezime"].ToString();
            s.Jmbg = red["JMBG"].ToString();
            s.KorisnickoIme = red["KorisnickoIme"].ToString();
            s.KorisnickaSifra = red["KorisnickaSifra"].ToString();
            return s;
        }
        #endregion
    }
}
