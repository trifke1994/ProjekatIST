using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ProjekatIST.Model;

namespace ProjekatIST
{
    [ServiceContract]
    public interface IWebBioskop
    {
        [OperationContract]

        [WebInvoke(Method = "POST", UriTemplate = "Prijava/{korisnickoIme}&{lozinka}", ResponseFormat = WebMessageFormat.Json)]
        bool Prijava(string korisnickoIme, string lozinka);

        [WebGet(UriTemplate = "slobodnaIzauzetaMesta/{projekcija}",ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Dictionary<string, int> SlobodnaIZauzetaMesta(string projekcija);

        [WebGet(UriTemplate = "/projekcija/{projekcijaId}&korisnicko/{korisnickoIme}",ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool RezervacijaKarata(string projekcijaId, string korisnickoIme);

        [WebGet(UriTemplate = "projekcije", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Projekcija> VratiProjekcije();

        [OperationContract]
        [WebGet(UriTemplate = "mojaRezervacija/{korisnickoIme}", ResponseFormat = WebMessageFormat.Json)]
        List<Rezervacija> VratiKorisnikoveRezervacije(string korisnickoIme);
    }
}