using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CilentWeb.Model;

namespace Klijent
{
    public partial class Rezervacija : Form
    {
        private static string korisnickoIme = "";
        public Rezervacija(string korisnicko)
        {
            korisnickoIme = korisnicko;
            InitializeComponent();
        }
     
        #region Metods

        private void Gasenje()
        {
            Close();
        }

        private void PostaviProjekcije(ComboBox cmb)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5666/ProjekatIST/Bioskop/projekcije");
            var response = (HttpWebResponse)request.GetResponse();

            var r = new DataContractJsonSerializer(typeof(List<Projekcija>));
            var projekcije = r.ReadObject(response.GetResponseStream()) as List<Projekcija>;

            var listaProjekcija = projekcije;
            cmb.DataSource = listaProjekcija;
            cmb.ValueMember = "id_projekcija";
            cmb.DisplayMember = "Naziv";
        }

        #endregion



        #region Events

        private void btnSlobodnaMestaProjekcija_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5666/ProjekatIST/Bioskop/slobodnaIzauzetaMesta/"+cmbProjekcije.SelectedValue);
            var response = (HttpWebResponse)request.GetResponse();

            var r = new DataContractJsonSerializer(typeof(Dictionary<string, int>));
            var rezervacije = r.ReadObject(response.GetResponseStream()) as Dictionary<string,int>;
            foreach (var rez in rezervacije)
            {
                lstRezultatZaProjekcije.Items.Add(rez.Key + " " + rez.Value);
            }
        }

        private void btnSlobodnaMestaOdustani_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        private void btnPreuzmiProjekcije_Click(object sender, EventArgs e)
        {
            PostaviProjekcije(cmbProjekcije);
        }

        private void btnKorisnikoveRezervacijeOK_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5666/ProjekatIST/Bioskop/mojaRezervacija/" + korisnickoIme);
            var response = (HttpWebResponse)request.GetResponse();

            var r = new DataContractJsonSerializer(typeof(List<CilentWeb.Model.Rezervacija>));
            var rezervacije = r.ReadObject(response.GetResponseStream()) as List<CilentWeb.Model.Rezervacija>;

            foreach (var rezervacija in rezervacije)
            {
                lstKorisnickeRez.Items.Add("Vase rezervacije: " + rezervacija.KorisnickoIme + " Datum isteka: " + rezervacija.datum_isteka + " Datum kreiranja: " +
                                         rezervacija.datum_kreiranja);
            }
        }

        private void btnKorisnikoveRezOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreuzmiProj_Click(object sender, EventArgs e)
        {
            PostaviProjekcije(cmbSveProjekcije);
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5666/ProjekatIST/Bioskop/projekcija/" + cmbSveProjekcije.SelectedValue + "&korisnicko/" + korisnickoIme);
            var response = request.GetResponse().GetResponseStream();

            var r = new DataContractJsonSerializer(typeof(bool));
            var rez = r.ReadObject(response) as bool?;

            if (rez != null && (bool)rez)
            {
                lblUpoRezervacija.Text = "Uspesno ste rezervisali kartu";
                return;
            }
            lblUpoRezervacija.Text = "Niste rezevisali vasu kartu.";
        }

        private void btnOdustaniRezervacija_Click(object sender, EventArgs e)
        {
            Gasenje();
        }

        #endregion



        

    
    }
}