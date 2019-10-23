using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAngazovaniStudent
{
    public class PronadjiAngazovanogStudenta : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiJedanZaOpstiUslov(odo) as AngazovaniStudent;
        }
    }
}
