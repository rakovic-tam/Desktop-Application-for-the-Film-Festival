using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAkreditovaniNovinar
{
    public class UcitajSveMedijskeKuce : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            MedijskaKuca mk = new MedijskaKuca();
            mk.USLOVI = " Naziv is null";
            Sesija.Broker.dajSesiju().deleteVise(mk);
            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<MedijskaKuca>().ToList<MedijskaKuca>();
        }
    }
}
