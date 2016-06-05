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
using AdminKlijent.BioskopService;

namespace AdminKlijent
{
    public partial class Prijava : Form
    {
        private AdminBioskopClient client = new AdminBioskopClient(new NetTcpBinding(),new EndpointAddress(new Uri("net.tcp://127.0.0.1:5678/ProjekatIST/Bioskop/Nesto")));
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
