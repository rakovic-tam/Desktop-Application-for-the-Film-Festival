using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAkreditovaniNovinar
{
    public class UcitajSveAkreditovaneNovinare : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            AkreditovaniNovinar an = new AkreditovaniNovinar();
            an.USLOVI = " Ime is null";
            Sesija.Broker.dajSesiju().deleteVise(an);
            List<AkreditovaniNovinar> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<AkreditovaniNovinar>().ToList<AkreditovaniNovinar>();
            foreach (AkreditovaniNovinar akrNovinar in lista)
            {
                akrNovinar.MedijskaKuca = Sesija.Broker.dajSesiju().vratiJedanZaID(akrNovinar.MedijskaKuca) as MedijskaKuca;
            }
            return lista;
        }
    }
}
