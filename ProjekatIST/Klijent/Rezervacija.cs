using System;
using System.ServiceModel;
using System.Windows.Forms;
using Klijent.BiskopServis;

namespace Klijent
{
    public partial class Rezervacija : Form
    {
        private BioskopClient _client = new BioskopClient(new BasicHttpBinding(), new EndpointAddress(new Uri("http://127.0.0.1:8080/ProjekatIST/Bioskop/BasicHttp/")));
        private static string korisnickoIme;
        public Rezervacija(string korisnik)
        {
            korisnickoIme = korisnik;
            InitializeComponent();
        }

        #region Metods

        private void Gasenje()
        {
            _client.Close();
            Close();
        }

        #endregion

        private void btnPreuzmiProj_Click(object sender, EventArgs e)
        {
            var listaProjekcija = _client.VratiProjekcije();
            cmbSveProjekcije.DataSource = listaProjekcija;
            cmbSveProjekcije.ValueMember = "id_projekcija";
            cmbSveProjekcije.DisplayMember = "Naziv";
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (_client.RezervacijaKarte(Convert.ToInt32(cmbSveProjekcije.SelectedValue), korisnickoIme))
            {
                lblUpoRez.Text = "Uspesno ste rezervisai kartu!!!";
                return;
            }

            lblUpoRez.Text = "Dpslo je do problema niste rezervisali kartu!!!";
        }

        private void btnOdustaniRezervacija_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        #region Events

        private void btnSlobodnaMestaProjekcija_Click(object sender, EventArgs e)
        {
            var mesta = _client.slobodnaIZauzetaMesta(Convert.ToInt32(cmbProjekcije.SelectedValue));
            foreach (var item in mesta)
            {
                lstRezultatZaProjekcije.Items.Add(item.Key + ": " + item.Value);
            }
        }

        private void btnSlobodnaMestaOdustani_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnPreuzmiProjekcije_Click(object sender, EventArgs e)
        {
            var listaProjekcija = _client.VratiProjekcije();
            cmbProjekcije.DataSource = listaProjekcija;
            cmbProjekcije.ValueMember = "id_projekcija";
            cmbProjekcije.DisplayMember = "Naziv";
        }

        #endregion

        private void btnKorisnikoveRezervacijeOK_Click(object sender, EventArgs e)
        {
            var rez = _client.VratiKorisnikoveRezervacije(korisnickoIme);
            foreach (var rezervacija in rez)
            {
                lstKorisnickeRez.Items.Add("Vase rezervacije: " + rezervacija.KorisnickoIme + " Datum isteka: " + rezervacija.datum_isteka + " Datum kreiranja: " +
                                         rezervacija.datum_kreiranja);
            }
        }

        private void btnKorisnikoveRezOdustani_Click(object sender, EventArgs e)
        {
            Gasenje();
        }
    }
}