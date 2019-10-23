using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SORaspored
{
    public class PronadjiRasporede : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Raspored> lista = Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Raspored>().ToList<Raspored>();
            foreach (Raspored r in lista)
            {
                r.Projekcija = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Projekcija) as Projekcija;
                r.Projekcija.Film = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Projekcija.Film) as Film;
                r.AkreditovaniNovinar = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AkreditovaniNovinar) as AkreditovaniNovinar;
                r.AkreditovaniNovinar.MedijskaKuca = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AkreditovaniNovinar.MedijskaKuca) as MedijskaKuca;
                r.AngazovaniStudent = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AngazovaniStudent) as AngazovaniStudent;
            }
            return lista;

        }
    }
}
