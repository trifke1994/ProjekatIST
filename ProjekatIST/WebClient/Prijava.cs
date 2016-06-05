using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClient
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();

           

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5667/ProjekatIST/Bioskop/");

            var postData = "korisnickoIme="+txtbKorisnik.Text;
            postData += "&lozinka="+txtbPassword.Text;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "/prijava/korisnickoIme/{korisnickoIme}&lozinka/{lozinka}";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

           

        }
    }
}
