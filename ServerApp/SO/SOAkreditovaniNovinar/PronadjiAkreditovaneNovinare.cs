using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAkreditovaniNovinar
{
    public class PronadjiAkreditovaneNovinare : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<AkreditovaniNovinar> lista = Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<AkreditovaniNovinar>().ToList<AkreditovaniNovinar>();
            foreach(AkreditovaniNovinar ak in lista)
            {
                ak.MedijskaKuca = Sesija.Broker.dajSesiju().vratiJedanZaID(ak.MedijskaKuca) as MedijskaKuca;
            }
            return lista;
        }
    }
}
