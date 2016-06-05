using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using ProjekatIST.Model;

namespace ProjekatIST
{
    public class Bioskop : IBioskop, IAdminBioskop, IWebBioskop
    {
        #region VariabeInit

        private static readonly List<Korisnik> _korisnici = new List<Korisnik>
        {
            new Korisnik {KorisnickoIme = "admin", Lozinka = "super"}
        };

        private static readonly List<Rezervacija> _rezervacije = new List<Rezervacija>();

        private static readonly List<Projekcija> _projekcije = new List<Projekcija>
        {
            new Projekcija {id_projekcija = 0, BrojMesta = 10, Naziv = "LEpo", Sala = 1, Vreme = DateTime.Now}
        };

        private static readonly List<Karta> _karte = new List<Karta> {new Karta {Cena = 2000, id_projekcija = 0}};

        #endregion

        #region IBioskop

        public int SlobodnoMesta(int projekcijaid)
        {
            var projekcijaId = Convert.ToInt32(projekcijaid);
            var projekcija = _projekcije.FirstOrDefault(w => w.id_projekcija == projekcijaId);
            var karte = _karte.Count(c => c.id_projekcija == projekcijaId);
            if (projekcija == null || projekcija.BrojMesta - karte <= 0)
            {
                return 0;
            }

            return projekcija.BrojMesta - karte;
        }

        public bool IzmenaProjekcije(int idproj, string noviNaziv = "", int novaSala = -5, int novikapacitet = 0,
            DateTime novoVreme = default(DateTime))
        {
            var projekcija = _projekcije.FirstOrDefault(f => f.id_projekcija.Equals(idproj));
            if (projekcija == null)
                return false;
            projekcija.Naziv = noviNaziv == "" ? projekcija.Naziv : noviNaziv;
            projekcija.Sala = novaSala == -5 ? projekcija.Sala : novaSala;
            projekcija.Vreme = novoVreme == default(DateTime) ? projekcija.Vreme : novoVreme;
            projekcija.BrojMesta = novikapacitet;
            return true;
        }

        public Dictionary<string, int> slobodnaIZauzetaMesta(int projekcija)
        {
            var mesta = new Dictionary<string, int>();
            var id_projekcije = Convert.ToInt32(projekcija);
            var rezervacije = _rezervacije.Count(c => c.id_projekcija == id_projekcije);
            var mestaZaProjekciju = _projekcije.FirstOrDefault(f => f.id_projekcija == id_projekcije);
            if (mestaZaProjekciju == null) return mesta;

            mesta.Add("Zauzeta", rezervacije);
            mesta.Add("Slobodna", mestaZaProjekciju.BrojMesta - rezervacije);
            return mesta;
        }

        public bool UnosKarata(int projekcijaid, double cena)
        {
            try
            {
                var kartaPostoji = _karte.FirstOrDefault(f => f.id_projekcija == projekcijaid);
                if (kartaPostoji != null) return false;
                var karta = new Karta {Cena = cena, id_projekcija = projekcijaid};
                _karte.Add(karta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Rezervacija> RezervacijeKojeIsticu()
        {
            return _rezervacije.Where(w => DateTime.Now.Minute - w.datum_isteka.Minute < 30).ToList();
        }

        public bool UnosKorisnika(string korisnik, string lozinka)
        {
            try
            {
                var kor = new Korisnik {KorisnickoIme = korisnik, Lozinka = lozinka};
                if (_korisnici.FirstOrDefault(f => f.KorisnickoIme == kor.KorisnickoIme) == null)
                {
                    _korisnici.Add(kor);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IzmenaKorisnika(string korisnik, string novoIme, string novaLozinka)
        {
            var korisnikNadjen = _korisnici.FirstOrDefault(f => f.KorisnickoIme.Equals(korisnik));
            if (korisnikNadjen != null)
            {
                korisnikNadjen.KorisnickoIme = string.IsNullOrEmpty(novoIme) ? korisnikNadjen.KorisnickoIme : novoIme;
                korisnikNadjen.Lozinka = string.IsNullOrEmpty(novaLozinka) ? korisnikNadjen.Lozinka : novoIme;
                return true;
            }

            return false;
        }

        public bool UnosProjekcija(string naziv, int sala, int kapacitet, DateTime vreme)
        {
            try
            {
                var projekcija = new Projekcija
                {
                    id_projekcija = _projekcije.Count + 1,
                    Naziv = naziv,
                    Sala = sala,
                    Vreme = vreme,
                    BrojMesta = kapacitet
                };
                _projekcije.Add(projekcija);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RezervacijaKarte(int projekcijaId, string korisnickoIme)
        {
            try
            {
                var projekcija = _projekcije.FirstOrDefault(w => w.id_projekcija == projekcijaId);
                var rezervacije = _rezervacije.Count(c => c.id_projekcija == projekcijaId);
                if (projekcija == null || projekcija.BrojMesta - rezervacije <= 0)
                {
                    return false;
                }
                var karta = _karte.FirstOrDefault(f => f.id_projekcija == projekcijaId);
                var novaRezervacija = new Rezervacija
                {
                    id_karta = karta.id_karta,
                    datum_isteka = DateTime.Now.AddMinutes(30),
                    datum_kreiranja = DateTime.Now,
                    id_projekcija = projekcijaId,
                    id_rezervacija = _rezervacije.Count + 1,
                    KorisnickoIme = korisnickoIme
                };
                _rezervacije.Add(novaRezervacija);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region IWebBioskop

        [WebGet(UriTemplate = "projekcije", ResponseFormat = WebMessageFormat.Json)]
        public List<Projekcija> VratiProjekcije()
        {
            return _projekcije;
        }

        [WebGet(UriTemplate = "slobodnaIzauzetaMesta/{projekcija}", ResponseFormat = WebMessageFormat.Json)]
        public Dictionary<string, int> SlobodnaIZauzetaMesta(string projekcija)
        {
            var mesta = new Dictionary<string, int>();
            var id_projekcije = Convert.ToInt32(projekcija);
            var rezervacije = _rezervacije.Count(c => c.id_projekcija == id_projekcije);
            var mestaZaProjekciju = _projekcije.FirstOrDefault(f => f.id_projekcija == id_projekcije);
            if (mestaZaProjekciju == null) return mesta;

            mesta.Add("Zauzeta", rezervacije);
            mesta.Add("Slobodna", mestaZaProjekciju.BrojMesta - rezervacije);
            return mesta;
        }

        [WebGet(UriTemplate = "/projekcija/{projekcijaId}&korisnicko/{korisnickoIme}",
            ResponseFormat = WebMessageFormat.Json)]
        public bool RezervacijaKarata(string projekcijaId, string korisnickoIme)
        {
            try
            {
                var projekcijaid = Convert.ToInt32(projekcijaId);
                var projekcija = _projekcije.FirstOrDefault(w => w.id_projekcija == projekcijaid);
                var rezervacije = _rezervacije.Count(c => c.id_projekcija == projekcijaid);
                if (projekcija == null || projekcija.BrojMesta - rezervacije <= 0)
                {
                    return false;
                }
                var karta = _karte.FirstOrDefault(f => f.id_projekcija == projekcijaid);
                var novaRezervacija = new Rezervacija
                {
                    id_karta = karta.id_karta,
                    datum_isteka = DateTime.Now.AddMinutes(30),
                    datum_kreiranja = DateTime.Now,
                    id_projekcija = projekcijaid,
                    id_rezervacija = _rezervacije.Count + 1,
                    KorisnickoIme = korisnickoIme
                };
                _rezervacije.Add(novaRezervacija);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebGet(UriTemplate = "projekcija/{projekcijaid}")]
        public int SlobodnoMesta(string projekcijaid)
        {
            var projekcijaId = Convert.ToInt32(projekcijaid);
            var projekcija = _projekcije.FirstOrDefault(w => w.id_projekcija == projekcijaId);
            var rezervacije = _rezervacije.Count(c => c.id_projekcija == projekcijaId);
            if (projekcija == null || projekcija.BrojMesta - rezervacije <= 0)
            {
                return 0;
            }

            return projekcija.BrojMesta - rezervacije;
        }

        [WebInvoke(Method = "POST", UriTemplate = "Prijava/{korisnickoIme}&{lozinka}",
            ResponseFormat = WebMessageFormat.Json)]
        public bool Prijava(string korisnickoIme, string lozinka)
        {
            var k = _korisnici.FirstOrDefault(f => f.KorisnickoIme.Equals(korisnickoIme) && f.Lozinka.Equals(lozinka));
            if (k == null)
                return false;

            return true;
        }

        [WebGet(UriTemplate = "mojaRezervacija/{korisnickoIme}", ResponseFormat = WebMessageFormat.Json)]
        public List<Rezervacija> VratiKorisnikoveRezervacije(string korisnickoIme)
        {
            return _rezervacije.Where(w => string.Equals(korisnickoIme, w.KorisnickoIme)).ToList();
        }

        #endregion

        #region IAdminBioskop

        public bool ObrisiProjekciju(int idProjekcije)
        {
            try
            {
                var projekcija = _projekcije.FirstOrDefault(f => f.id_projekcija == idProjekcije);
                if (projekcija != null)
                {
                    _projekcije.Remove(projekcija);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ObrisiRezervaciju(int idRezervacija)
        {
            try
            {
                var rezervacija = _rezervacije.FirstOrDefault(f => f.id_rezervacija == idRezervacija);
                if (rezervacija != null)
                {
                    _rezervacije.Remove(rezervacija);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ObrisiKorisnika(string korisnicko)
        {
            try
            {
                var korisnik = _korisnici.FirstOrDefault(f => string.Equals(f.KorisnickoIme, korisnicko));
                if (korisnik != null)
                {
                    _korisnici.Remove(korisnik);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Korisnik> VratiKorisnike()
        {
            return _korisnici;
        }

        public List<Rezervacija> VratRezervacijae()
        {
            return _rezervacije;
        }

        #endregion
    }
}