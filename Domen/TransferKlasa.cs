using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        PronadjiAngazovanogStudenta=2,
        KreirajMedijskuKucu=3,
        ZapamtiMedijskuKucu=4,
        UcitajSveMedijskeKuce=5,
        KreirajAkreditovanogNovinara=6,
        ZapamtiAkreditovanogNovinara=7,
        PronadjiAkreditovaneNovinare=8,
        UcitajAkreditovanogNovinara=9, 
        KreirajAngazovanogStudenta=10,
        ZapamtiAngazovanogStudenta=11,
        UcitajSveAkreditovaneNovinare=12,
        UcitajProjekcije=13,
        KreirajRaspored = 14,
        ZapamtiRaspored = 15,
        PronadjiRasporede = 16,
        UcitajRaspored = 17,
        VratiRasporedeZaUslov = 18
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
