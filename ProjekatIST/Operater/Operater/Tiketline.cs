using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
using Operater.BioskopServis;

namespace Operater
{
    public partial class Tiketline : Form
    {
        private BioskopClient _client = new BioskopClient(new BasicHttpBinding(), new EndpointAddress(new Uri("http://127.0.0.1:8080/ProjekatIST/Bioskop/BasicHttp/")));
        private static string korisnickoIme = "";

        private readonly Dictionary<int, string> _labele = new Dictionary<int, string>
        {
            {0, "Dogodila se greska! Pokusate ponovo"},
            {1, "Uspesno ste dodali korisnika!"},
            {2, "Uspesno ste izmenili korisnika!!"},
            {3, "Morate uneti sve podatke!"},
            {4, "Uspesno ste dodali projekciju!!"},
            {5, "Uspesno ste izmenili projekciju"},
            {6, "Uspesno ste rezerisali kartu!!" },
            {7,"Uspesno ste dodali kartu!!!" }
        };

        public Tiketline(string kor)
        {
            InitializeComponent();
            korisnickoIme = kor;
            var projekcije = _client.VratiProjekcije();
            ProjekcijeGrid.DataSource = projekcije;
            PostaviCmbProjekcije(cmbIzborProjekcije);
        }

        #region Metods

        private void Gasenje()
        {
            _client.Close();
            Close();
        }

        private void PostaviCmbProjekcije(ComboBox projekcje)
        {
            var listaProjekcija = _client.VratiProjekcije();
            projekcje.DataSource = listaProjekcija;
            projekcje.ValueMember = "id_projekcija";
            projekcje.DisplayMember = "Naziv";
        }
        #endregion

        #region Events

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbKorisnickoIme.Text) && !string.IsNullOrEmpty(txtbLozinka.Text))
            {
                var rez = _client.UnosKorisnika(txtbKorisnickoIme.Text, txtbLozinka.Text);
                lblUpozorenje.Text = rez ? _labele[1] : _labele[0];
            }
            else
            {
                lblUpozorenje.Text = _labele[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var rez = _client.IzmenaKorisnika(txtbKorisnickoIme.Text, txtbNovoIme.Text, txtbNovaLozinka.Text);
            lblUpozo.Text = rez ? _labele[2] : _labele[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnOKRezervacijaKarata_Click(object sender, EventArgs e)
        {
            var rez = _client.UnosKarata((int) cmbIzborProjekcije.SelectedValue, double.Parse(txtbCenaKarte.Text));
            lblUpo.Text = rez ? _labele[7] : _labele[0];
        }

        private void btnCancelRezervacijaKarata_Click(object sender, EventArgs e)
        {
            Gasenje();
        }


        private void btnSnimiProjekciju_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNazivProjekcije.Text) || string.IsNullOrWhiteSpace(txtbSala.Text))
            {
                lblUpoProjekcija.Text = _labele[3];
                return;
            }
            var broj = string.IsNullOrEmpty(txtbSala.Text) ? "0":txtbSala.Text;
            var kap = string.IsNullOrEmpty(txtbKapacitet.Text) ? "0":txtbKapacitet.Text;
            var rez = _client.UnosProjekcija(txtbNazivProjekcije.Text, Convert.ToInt32(broj),Convert.ToInt32(kap), dtVremePrjekcijeUnos.Value);
            lblUpoProjekcija.Text = rez ? _labele[4] : _labele[0];
        }

        private void btnOdustaniProjekcija_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnIzlistaProjekcijeKojeIsticu_Click(object sender, EventArgs e)
        {
            var listaProjekcija = _client.RezervacijeKojeIsticu();
            dtIstekleRezevacije.DataSource = listaProjekcija;
        }

        private void btnOdustaniIzlistaj_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnIzmenaProjekcije_Click(object sender, EventArgs e)
        {
            var broj = string.IsNullOrEmpty(txtbNovaSala.Text) ? txtbNovaSala.Text : "0";
            var kap = string.IsNullOrEmpty(txtbNoviKapacitet.Text) ? txtbNoviKapacitet.Text : "0";
            var rez = _client.IzmenaProjekcije((int) cmbProjekcija.SelectedValue, txtbNoviNazivProjekcije.Text,
                Convert.ToInt32(broj),Convert.ToInt32(kap), dtNovoVremeProjekcije.Value);
            lblUpozorenjeIZmena.Text = rez ? _labele[0] : _labele[5];
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnPreuzmiProjekcije_Click(object sender, EventArgs e)
        {
            PostaviCmbProjekcije(cmbSveProjekcije);
        }

        private void btnPreuzmiProj_Click(object sender, EventArgs e)
        {
            PostaviCmbProjekcije(cmbProjekcija);
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            var rez = _client.RezervacijaKarte((int)cmbSveProjekcije.SelectedValue, korisnickoIme);

            lblUpoRezervacijaKarata.Text = rez ? _labele[6] : _labele[0];
        }




        #endregion

        private void btnOseziUnosKarata_Click(object sender, EventArgs e)
        {
            var projekcije = _client.VratiProjekcije();
            ProjekcijeGrid.DataSource = projekcije;
            PostaviCmbProjekcije(cmbIzborProjekcije);
        }
    }
}