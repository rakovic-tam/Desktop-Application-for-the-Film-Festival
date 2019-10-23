using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOMedijskaKuca
{
    public class KreirajMedijskuKucu:OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            MedijskaKuca mk = new MedijskaKuca();
            mk.MedijskaKucaID = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(mk);
            return mk;
        }
    }
}
