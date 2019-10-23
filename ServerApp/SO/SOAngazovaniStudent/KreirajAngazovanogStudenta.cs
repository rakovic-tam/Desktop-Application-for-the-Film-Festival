using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SOAngazovaniStudent
{
    public class KreirajAngazovanogStudenta : OpstaSistemskaOperacija
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            AngazovaniStudent ast = new AngazovaniStudent();
            ast.AngazovaniStudentID = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(ast);
            return ast;
        }
    }
}
