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
    public class MedijskaKuca:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        int medijskaKucaID;
        string naziv;
        string vlasnik;

        public int MedijskaKucaID { get => medijskaKucaID; set => medijskaKucaID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Vlasnik { get => vlasnik; set => vlasnik = value; }


        
        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "MedijskaKuca";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "MedijskaKucaiD";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " MedijskaKucaiD=" + MedijskaKucaID;
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
                return "(MedijskaKucaiD) values (" + MedijskaKucaID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Naziv='" + Naziv + "', Vlasnik='" + Vlasnik + "'";
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
            MedijskaKuca mk = new MedijskaKuca();
            mk.MedijskaKucaID = Convert.ToInt32(red["MedijskaKucaiD"]);
            mk.Naziv = red["Naziv"].ToString();
            mk.Vlasnik = red["Vlasnik"].ToString();
            return mk;
        }
        #endregion
    }
}
