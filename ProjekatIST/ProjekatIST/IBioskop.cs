using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ProjekatIST.Model;

namespace ProjekatIST
{
    [ServiceContract]
    public interface IBioskop
    {
        [OperationContract]
        bool Prijava(string korisnickoIme, string lozinka);

        [OperationContract]
        Dictionary<string, int> slobodnaIZauzetaMesta(int projekcija);

        [OperationContract]
        bool RezervacijaKarte(int projekcijaId,string korisnickoIme);

        [OperationContract]
        bool UnosKarata(int projekcija_id, double cena);

        [OperationContract]
        List<Rezervacija> RezervacijeKojeIsticu();

        [OperationContract]
        bool UnosProjekcija(string naziv, int sala,int kapacitet, DateTime vreme);

        [OperationContract]
        bool IzmenaProjekcije(int idproj, string noviNaziv, int novaSala, int novikapacitet, DateTime novoVreme);

        [OperationContract]
        bool UnosKorisnika(string korisnik, string lozinka);

        [OperationContract]
        bool IzmenaKorisnika(string korisnik, string novoIme, string novaLozinka);

        [OperationContract]
        List<Projekcija> VratiProjekcije();

        [OperationContract]
        List<Rezervacija> VratiKorisnikoveRezervacije(string korisnickoIme);
    }
}