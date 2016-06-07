using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operater.BioskopServis;

namespace Operater
{
    public partial class Prijava : Form
    {
        private BioskopClient client = new BioskopClient(new BasicHttpBinding(),new EndpointAddress(new Uri("http://127.0.0.1:8080/ProjekatIST/Bioskop/BasicHttp/")));
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!client.Prijava(txtbKorisnickoIme.Text, txtbLozinka.Text))
            {
                lblUpozorenje.Text = "Uneli ste neispravne podatke!!";
                lblUpozorenje.ForeColor = Color.Red;
                return;
            }
            this.Hide();
            Tiketline tk = new Tiketline(txtbKorisnickoIme.Text);
            tk.ShowDialog();
            client.Close();
            this.Close();
                    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            client.Close();
            this.Close();
        }
    }
}
