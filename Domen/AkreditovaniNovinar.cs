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
    public class AkreditovaniNovinar:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }
        int akreditovaniNovinarID;
        string ime;
        string prezime;
        string jmbg;
        string email;
        string brojTelefona;
        MedijskaKuca medijskaKuca;

        [Browsable(false)]
        public int AkreditovaniNovinarID { get => akreditovaniNovinarID; set => akreditovaniNovinarID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        [DisplayName("JMBG")]
        public string Jmbg { get => jmbg; set => jmbg = value; }
        [DisplayName("E-mail")]
        public string Email { get => email; set => email = value; }
        [DisplayName("Broj telefona")]
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        [DisplayName("Medijska kuća")]
        public MedijskaKuca MedijskaKuca { get => medijskaKuca; set => medijskaKuca = value; }

        

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "AkreditovaniNovinar";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "AkreditovaniNovinarID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " AkreditovaniNovinarID=" + AkreditovaniNovinarID;
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
                return "(AkreditovaniNovinarID) values (" + AkreditovaniNovinarID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='" + Ime + "', Prezime='" + Prezime + "', JMBG='" + Jmbg + "', Email='"+Email+"', BrojTelefona='"+BrojTelefona+"', MedijskaKucaiD="+MedijskaKuca.MedijskaKucaID+"";
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
            AkreditovaniNovinar ak = new AkreditovaniNovinar();
            ak.AkreditovaniNovinarID = Convert.ToInt32(red["AkreditovaniNovinarID"]);
            ak.Ime = red["Ime"].ToString();
            ak.Prezime = red["Prezime"].ToString();
            ak.Jmbg = red["JMBG"].ToString();
            ak.Email = red["Email"].ToString();
            ak.BrojTelefona = red["BrojTelefona"].ToString();
            ak.MedijskaKuca = new MedijskaKuca();
            ak.MedijskaKuca.MedijskaKucaID = Convert.ToInt32(red["MedijskaKucaiD"]);
            return ak;
        }
        #endregion
    }
}
