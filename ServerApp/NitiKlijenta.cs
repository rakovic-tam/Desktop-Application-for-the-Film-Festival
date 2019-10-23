using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using ServerApp.SO.SOAngazovaniStudent;
using ServerApp.SO.SOMedijskaKuca;
using ServerApp.SO.SOAkreditovaniNovinar;
using ServerApp.SO.SORaspored;
using Sesija;



namespace ServerApp
{
    class NitiKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitiKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart nitDelegat = obradiZahtev;
            new Thread(nitDelegat).Start();
        }

        void obradiZahtev()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {
                        case Operacije.PronadjiAngazovanogStudenta:
                            PronadjiAngazovanogStudenta astudent = new PronadjiAngazovanogStudenta();
                            transfer.Rezultat = astudent.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajMedijskuKucu:
                            KreirajMedijskuKucu umk = new KreirajMedijskuKucu();
                            transfer.Rezultat = umk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiMedijskuKucu:
                            ZapamtiMedijskuKucu zmk = new ZapamtiMedijskuKucu();
                            transfer.Rezultat = zmk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajSveMedijskeKuce:
                            UcitajSveMedijskeKuce usmk = new UcitajSveMedijskeKuce();
                            transfer.Rezultat = usmk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajAkreditovanogNovinara:
                            KreirajAkreditovanogNovinara kan = new KreirajAkreditovanogNovinara();
                            transfer.Rezultat = kan.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiAkreditovanogNovinara:
                            ZapamtiAkreditovanogNovinara zan = new ZapamtiAkreditovanogNovinara();
                            transfer.Rezultat = zan.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiAkreditovaneNovinare:
                            PronadjiAkreditovaneNovinare pan = new PronadjiAkreditovaneNovinare();
                            transfer.Rezultat = pan.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajAkreditovanogNovinara:
                            UcitajAkreditovanogNovinara uan = new UcitajAkreditovanogNovinara();
                            transfer.Rezultat = uan.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajAngazovanogStudenta:
                            KreirajAngazovanogStudenta kas = new KreirajAngazovanogStudenta();
                            transfer.Rezultat = kas.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiAngazovanogStudenta:
                            ZapamtiAngazovanogStudenta zas = new ZapamtiAngazovanogStudenta();
                            transfer.Rezultat = zas.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajSveAkreditovaneNovinare:
                            UcitajSveAkreditovaneNovinare usan = new UcitajSveAkreditovaneNovinare();
                            transfer.Rezultat = usan.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajProjekcije:
                            UcitajProjekcije up = new UcitajProjekcije();
                            transfer.Rezultat = up.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajRaspored:
                            KreirajRaspored kr = new KreirajRaspored();
                            transfer.Rezultat = kr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRaspored:
                            ZapamtiRaspored zr = new ZapamtiRaspored();
                            transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiRasporede:
                            PronadjiRasporede pr = new PronadjiRasporede();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajRaspored:
                            UcitajRaspored ur = new UcitajRaspored();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiRasporedeZaUslov:
                            transfer.Rezultat = Broker.dajSesiju().vratiRasporedeZaUslov(transfer.TransferObjekat as string);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokovaKlijenata.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.listaTokovaKlijenata.Remove(tok);
                }
                catch (Exception)
                {

                   
                }
               
            }
        }
    }
}
