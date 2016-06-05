using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent;

namespace CilentWeb
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private static string korisnicko;
        private void btnOk_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5666/ProjekatIST/Bioskop/Prijava/" + txtbKorisnik.Text + "&" + txtbPassword.Text + "");
            korisnicko = txtbKorisnik.Text;
            var postData = "korisnickoIme=" + txtbKorisnik.Text;
            postData += "&lozinka=" + txtbPassword.Text;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            if (Convert.ToBoolean(responseString))
            {
                this.Hide();
               Rezervacija rz = new Rezervacija(korisnicko);              
                rz.ShowDialog();
                this.Close();
                
            }
            else
            {
                lblUpozorenje.Text = "Uneli ste pogresne podatke!!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
