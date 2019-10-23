using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SORaspored
{
    public class KreirajRaspored : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Projekcija p = new Projekcija();
            p.ProjekcijaID = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(p);
            return p;
        }
    }
}
