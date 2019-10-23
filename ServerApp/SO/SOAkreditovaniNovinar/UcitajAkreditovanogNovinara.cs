using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAkreditovaniNovinar
{
    public class UcitajAkreditovanogNovinara : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            AkreditovaniNovinar a = new AkreditovaniNovinar();
            a = Sesija.Broker.dajSesiju().vratiJedanZaID(odo) as AkreditovaniNovinar;
            a.MedijskaKuca = Sesija.Broker.dajSesiju().vratiJedanZaID(a.MedijskaKuca) as MedijskaKuca;
            return a;
        }
    }
}
