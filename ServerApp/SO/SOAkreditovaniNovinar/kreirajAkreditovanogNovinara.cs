using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.SOAkreditovaniNovinar
{
    public class KreirajAkreditovanogNovinara : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            AkreditovaniNovinar an = new AkreditovaniNovinar();
            an.AkreditovaniNovinarID = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(an);
            return an;
        }
    }
}
