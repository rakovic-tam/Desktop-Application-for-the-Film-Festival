using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace Domen
{
    public enum Status { Nеpromenjen, Dodat, Izmenjen, Obrisan }
    [Serializable]
    public class Raspored:OpstiDomenskiObjekat
    {
        Projekcija projekcija;
        AkreditovaniNovinar akreditovaniNovinar;
        DateTime datumIVreme;
        AngazovaniStudent angazovaniStudent;
        Status status;
        int stariIDProjekcije;
        int stariIDAkreditovanogNovinara;

        public Projekcija Projekcija { get => projekcija; set => projekcija = value; }
      
        [DisplayName("Akreditovani novinar")]
        public AkreditovaniNovinar AkreditovaniNovinar { get => akreditovaniNovinar; set => akreditovaniNovinar = value; }
        [DisplayName("Datum i vreme")]
        public DateTime DatumIVreme { get => datumIVreme; set => datumIVreme = value; }
        [DisplayName("Angažovani student")]
        public AngazovaniStudent AngazovaniStudent { get => angazovaniStudent; set => angazovaniStudent = value; }
        
        public Status Status { get => status; set => status = value; }
        [Browsable(false)]
        public int StariIDProjekcije { get => stariIDProjekcije; set => stariIDProjekcije = value; }
        [Browsable(false)]
        public int StariIDAkreditovanogNovinara { get => stariIDAkreditovanogNovinara; set => stariIDAkreditovanogNovinara = value; }




        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Raspored";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return null;
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " ProjekcijaID=" + Projekcija.ProjekcijaID + " and AkreditovaniNovinarID=" + AkreditovaniNovinar.AkreditovaniNovinarID;
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
                return "values (" + projekcija.ProjekcijaID + "," + akreditovaniNovinar.AkreditovaniNovinarID + ",'" + datumIVreme.ToString() +"', " + AngazovaniStudent.AngazovaniStudentID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return "DatumIVreme ='" + datumIVreme.ToString() + "', AngazovaniStudentID=" + AngazovaniStudent.AngazovaniStudentID + "";
            }
        }

        [Browsable(false)]
        public string Update2
        {
            get
            {
                return "ProjekcijaID=" + Projekcija.ProjekcijaID + ", AkreditovaniNovinarID=" + AkreditovaniNovinar.AkreditovaniNovinarID+ ", DatumIVreme = '" + datumIVreme.ToString() + "', AngazovaniStudentID=" + AngazovaniStudent.AngazovaniStudentID + "";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Raspored r = new Raspored();
            r.Projekcija = new Projekcija();
            r.Projekcija.ProjekcijaID = Convert.ToInt32(red["ProjekcijaID"]);
            r.AkreditovaniNovinar = new AkreditovaniNovinar();
            r.AkreditovaniNovinar.AkreditovaniNovinarID = Convert.ToInt32(red["AkreditovaniNovinarID"]);
            r.datumIVreme = Convert.ToDateTime(red["DatumIVreme"]);
            r.AngazovaniStudent = new AngazovaniStudent();
            r.AngazovaniStudent.AngazovaniStudentID = Convert.ToInt32(red["AngazovaniStudentID"]);
            return r;
        }
        #endregion
    }
}
