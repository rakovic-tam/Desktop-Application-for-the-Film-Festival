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
    public class Film:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }
        int filmID;
        string naziv;
        string zanr;

        public int FilmID { get => filmID; set => filmID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Zanr { get => zanr; set => zanr = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Film";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "FilmID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " FilmID=" + FilmID;
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
                return "(FilmID) values (" + FilmID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Naziv='" + Naziv + "', Zanr='" + Zanr + "'";
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
            Film f = new Film();
            f.FilmID = Convert.ToInt32(red["FilmID"]);
            f.Naziv = red["Naziv"].ToString();
            f.Zanr = red["Zanr"].ToString();
            return f;
        }
        #endregion
    }
}
