using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SORaspored
{
    public class UcitajProjekcije : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Projekcija pk = new Projekcija();
            pk.USLOVI = " NazivBioskopa is null";
            Sesija.Broker.dajSesiju().deleteVise(pk);
            List<Projekcija> listaProjekcija = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Projekcija>().ToList<Projekcija>();
            foreach(Projekcija p in listaProjekcija)
            {
                p.Film = Sesija.Broker.dajSesiju().vratiJedanZaID(p.Film) as Film;
            }

            return listaProjekcija;
        }
    }
}
