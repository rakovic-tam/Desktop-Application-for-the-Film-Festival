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
    public class Projekcija:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return film.ToString() + " | "+nazivBioskopa;
        }
        public Projekcija()
        {
             listaAkrNovinara = new BindingList<Raspored>();
        }
        int projekcijaID;
        string nazivBioskopa;
        int sala;
        Film film;
        BindingList<Raspored> listaAkrNovinara;

        [DisplayName("Projekcija ID")]
        public int ProjekcijaID { get => projekcijaID; set => projekcijaID = value; }
        [DisplayName("Naziv bioskopa")]
        public string NazivBioskopa { get => nazivBioskopa; set => nazivBioskopa = value; }
        public int Sala { get => sala; set => sala = value; }
        [Browsable(false)]
        public Film Film { get => film; set => film = value; }
        [Browsable(false)]
        public BindingList<Raspored> ListaAkrNovinara { get => listaAkrNovinara; set => listaAkrNovinara = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Projekcija";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "ProjekcijaID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " ProjekcijaID=" + ProjekcijaID;
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
                return "(ProjekcijaID) values (" + ProjekcijaID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " NazivBioskopa='" + NazivBioskopa + "', Sala=" + Sala + ", FilmID="+Film.FilmID+"";
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
            Projekcija p = new Projekcija();
            p.ProjekcijaID = Convert.ToInt32(red["ProjekcijaID"]);
            p.NazivBioskopa = red["NazivBioskopa"].ToString();
            p.Sala = Convert.ToInt32(red["Sala"]);
            p.Film = new Film();
            p.Film.FilmID = Convert.ToInt32(red["FilmID"]);
            return p;
        }
        #endregion
    }
}
