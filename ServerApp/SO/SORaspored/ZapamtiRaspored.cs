using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SORaspored
{
    public class ZapamtiRaspored : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Projekcija p = odo as Projekcija;

            foreach (Raspored r in p.ListaAkrNovinara)
            {
                switch (r.Status)
                {
                    case Status.Izmenjen:
                        Sesija.Broker.dajSesiju().update2(r);
                        break;
                    case Status.Obrisan:
                        Sesija.Broker.dajSesiju().deleteJedan(r);
                        break;
                    case Status.Dodat:
                        Sesija.Broker.dajSesiju().updateJedan(p);
                        Sesija.Broker.dajSesiju().insert(r);
                        break;
                }
            }
            return true;
        }
    }
}
