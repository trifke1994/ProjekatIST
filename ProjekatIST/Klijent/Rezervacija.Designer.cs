namespace Klijent
{
    partial class Rezervacija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbKlijent = new System.Windows.Forms.TabControl();
            this.tpSlobonaMesta = new System.Windows.Forms.TabPage();
            this.btnPreuzmiProjekcije = new System.Windows.Forms.Button();
            this.btnSlobodnaMestaOdustani = new System.Windows.Forms.Button();
            this.btnSlobodnaMestaProjekcija = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lstRezultatZaProjekcije = new System.Windows.Forms.ListBox();
            this.cmbProjekcije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUpozorenjeSlobodnaMesta = new System.Windows.Forms.Label();
            this.tpRezervacijaKarata = new System.Windows.Forms.TabPage();
            this.btnPreuzmiProj = new System.Windows.Forms.Button();
            this.cmbSveProjekcije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpoRez = new System.Windows.Forms.Label();
            this.btnOdustaniRezervacija = new System.Windows.Forms.Button();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.tpMojeRezervacije = new System.Windows.Forms.TabPage();
            this.btnKorisnikoveRezOdustani = new System.Windows.Forms.Button();
            this.btnKorisnikoveRezervacijeOK = new System.Windows.Forms.Button();
            this.lblVaseRez = new System.Windows.Forms.Label();
            this.lblUpozorenjeRezevacija = new System.Windows.Forms.Label();
            this.lstKorisnickeRez = new System.Windows.Forms.ListBox();
            this.tbKlijent.SuspendLayout();
            this.tpSlobonaMesta.SuspendLayout();
            this.tpRezervacijaKarata.SuspendLayout();
            this.tpMojeRezervacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKlijent
            // 
            this.tbKlijent.AllowDrop = true;
            this.tbKlijent.Controls.Add(this.tpSlobonaMesta);
            this.tbKlijent.Controls.Add(this.tpRezervacijaKarata);
            this.tbKlijent.Controls.Add(this.tpMojeRezervacije);
            this.tbKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKlijent.Location = new System.Drawing.Point(0, 0);
            this.tbKlijent.Name = "tbKlijent";
            this.tbKlijent.SelectedIndex = 0;
            this.tbKlijent.Size = new System.Drawing.Size(596, 358);
            this.tbKlijent.TabIndex = 0;
            // 
            // tpSlobonaMesta
            // 
            this.tpSlobonaMesta.Controls.Add(this.btnPreuzmiProjekcije);
            this.tpSlobonaMesta.Controls.Add(this.btnSlobodnaMestaOdustani);
            this.tpSlobonaMesta.Controls.Add(this.btnSlobodnaMestaProjekcija);
            this.tpSlobonaMesta.Controls.Add(this.lblRezultat);
            this.tpSlobonaMesta.Controls.Add(this.lstRezultatZaProjekcije);
            this.tpSlobonaMesta.Controls.Add(this.cmbProjekcije);
            this.tpSlobonaMesta.Controls.Add(this.label2);
            this.tpSlobonaMesta.Controls.Add(this.lblUpozorenjeSlobodnaMesta);
            this.tpSlobonaMesta.Location = new System.Drawing.Point(4, 22);
            this.tpSlobonaMesta.Name = "tpSlobonaMesta";
            this.tpSlobonaMesta.Padding = new System.Windows.Forms.Padding(3);
            this.tpSlobonaMesta.Size = new System.Drawing.Size(588, 332);
            this.tpSlobonaMesta.TabIndex = 0;
            this.tpSlobonaMesta.Text = "Slobodna mesta za projekcije";
            this.tpSlobonaMesta.UseVisualStyleBackColor = true;
            // 
            // btnPreuzmiProjekcije
            // 
            this.btnPreuzmiProjekcije.Location = new System.Drawing.Point(265, 55);
            this.btnPreuzmiProjekcije.Name = "btnPreuzmiProjekcije";
            this.btnPreuzmiProjekcije.Size = new System.Drawing.Size(113, 23);
            this.btnPreuzmiProjekcije.TabIndex = 7;
            this.btnPreuzmiProjekcije.Text = "Preuzmi projekcije";
            this.btnPreuzmiProjekcije.UseVisualStyleBackColor = true;
            this.btnPreuzmiProjekcije.Click += new System.EventHandler(this.btnPreuzmiProjekcije_Click);
            // 
            // btnSlobodnaMestaOdustani
            // 
            this.btnSlobodnaMestaOdustani.Location = new System.Drawing.Point(388, 282);
            this.btnSlobodnaMestaOdustani.Name = "btnSlobodnaMestaOdustani";
            this.btnSlobodnaMestaOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnSlobodnaMestaOdustani.TabIndex = 6;
            this.btnSlobodnaMestaOdustani.Text = "Odustani";
            this.btnSlobodnaMestaOdustani.UseVisualStyleBackColor = true;
            this.btnSlobodnaMestaOdustani.Click += new System.EventHandler(this.btnSlobodnaMestaOdustani_Click);
            // 
            // btnSlobodnaMestaProjekcija
            // 
            this.btnSlobodnaMestaProjekcija.Location = new System.Drawing.Point(488, 282);
            this.btnSlobodnaMestaProjekcija.Name = "btnSlobodnaMestaProjekcija";
            this.btnSlobodnaMestaProjekcija.Size = new System.Drawing.Size(75, 23);
            this.btnSlobodnaMestaProjekcija.TabIndex = 5;
            this.btnSlobodnaMestaProjekcija.Text = "U redu";
            this.btnSlobodnaMestaProjekcija.UseVisualStyleBackColor = true;
            this.btnSlobodnaMestaProjekcija.Click += new System.EventHandler(this.btnSlobodnaMestaProjekcija_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(74, 99);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(49, 13);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // lstRezultatZaProjekcije
            // 
            this.lstRezultatZaProjekcije.FormattingEnabled = true;
            this.lstRezultatZaProjekcije.Location = new System.Drawing.Point(129, 99);
            this.lstRezultatZaProjekcije.Name = "lstRezultatZaProjekcije";
            this.lstRezultatZaProjekcije.Size = new System.Drawing.Size(120, 95);
            this.lstRezultatZaProjekcije.TabIndex = 3;
            // 
            // cmbProjekcije
            // 
            this.cmbProjekcije.FormattingEnabled = true;
            this.cmbProjekcije.Location = new System.Drawing.Point(129, 57);
            this.cmbProjekcije.Name = "cmbProjekcije";
            this.cmbProjekcije.Size = new System.Drawing.Size(121, 21);
            this.cmbProjekcije.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izaberite projekciju:";
            // 
            // lblUpozorenjeSlobodnaMesta
            // 
            this.lblUpozorenjeSlobodnaMesta.AutoSize = true;
            this.lblUpozorenjeSlobodnaMesta.Location = new System.Drawing.Point(28, 27);
            this.lblUpozorenjeSlobodnaMesta.Name = "lblUpozorenjeSlobodnaMesta";
            this.lblUpozorenjeSlobodnaMesta.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeSlobodnaMesta.TabIndex = 0;
            // 
            // tpRezervacijaKarata
            // 
            this.tpRezervacijaKarata.Controls.Add(this.btnPreuzmiProj);
            this.tpRezervacijaKarata.Controls.Add(this.cmbSveProjekcije);
            this.tpRezervacijaKarata.Controls.Add(this.label1);
            this.tpRezervacijaKarata.Controls.Add(this.lblUpoRez);
            this.tpRezervacijaKarata.Controls.Add(this.btnOdustaniRezervacija);
            this.tpRezervacijaKarata.Controls.Add(this.btnRezervisi);
            this.tpRezervacijaKarata.Location = new System.Drawing.Point(4, 22);
            this.tpRezervacijaKarata.Name = "tpRezervacijaKarata";
            this.tpRezervacijaKarata.Padding = new System.Windows.Forms.Padding(3);
            this.tpRezervacijaKarata.Size = new System.Drawing.Size(588, 332);
            this.tpRezervacijaKarata.TabIndex = 1;
            this.tpRezervacijaKarata.Text = "Rezervacija karata";
            this.tpRezervacijaKarata.UseVisualStyleBackColor = true;
            // 
            // btnPreuzmiProj
            // 
            this.btnPreuzmiProj.Location = new System.Drawing.Point(267, 51);
            this.btnPreuzmiProj.Name = "btnPreuzmiProj";
            this.btnPreuzmiProj.Size = new System.Drawing.Size(113, 23);
            this.btnPreuzmiProj.TabIndex = 11;
            this.btnPreuzmiProj.Text = "Preuzmi projekcije";
            this.btnPreuzmiProj.UseVisualStyleBackColor = true;
            this.btnPreuzmiProj.Click += new System.EventHandler(this.btnPreuzmiProj_Click);
            // 
            // cmbSveProjekcije
            // 
            this.cmbSveProjekcije.FormattingEnabled = true;
            this.cmbSveProjekcije.Location = new System.Drawing.Point(131, 53);
            this.cmbSveProjekcije.Name = "cmbSveProjekcije";
            this.cmbSveProjekcije.Size = new System.Drawing.Size(121, 21);
            this.cmbSveProjekcije.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Izaberite projekciju:";
            // 
            // lblUpoRez
            // 
            this.lblUpoRez.AutoSize = true;
            this.lblUpoRez.Location = new System.Drawing.Point(30, 23);
            this.lblUpoRez.Name = "lblUpoRez";
            this.lblUpoRez.Size = new System.Drawing.Size(0, 13);
            this.lblUpoRez.TabIndex = 8;
            // 
            // btnOdustaniRezervacija
            // 
            this.btnOdustaniRezervacija.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustaniRezervacija.Location = new System.Drawing.Point(378, 283);
            this.btnOdustaniRezervacija.Name = "btnOdustaniRezervacija";
            this.btnOdustaniRezervacija.Size = new System.Drawing.Size(75, 23);
            this.btnOdustaniRezervacija.TabIndex = 6;
            this.btnOdustaniRezervacija.Text = "Odustani";
            this.btnOdustaniRezervacija.UseVisualStyleBackColor = true;
            this.btnOdustaniRezervacija.Click += new System.EventHandler(this.btnOdustaniRezervacija_Click);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezervisi.Location = new System.Drawing.Point(481, 283);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(75, 23);
            this.btnRezervisi.TabIndex = 5;
            this.btnRezervisi.Text = "U redu";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // tpMojeRezervacije
            // 
            this.tpMojeRezervacije.Controls.Add(this.btnKorisnikoveRezOdustani);
            this.tpMojeRezervacije.Controls.Add(this.btnKorisnikoveRezervacijeOK);
            this.tpMojeRezervacije.Controls.Add(this.lblVaseRez);
            this.tpMojeRezervacije.Controls.Add(this.lblUpozorenjeRezevacija);
            this.tpMojeRezervacije.Controls.Add(this.lstKorisnickeRez);
            this.tpMojeRezervacije.Location = new System.Drawing.Point(4, 22);
            this.tpMojeRezervacije.Name = "tpMojeRezervacije";
            this.tpMojeRezervacije.Padding = new System.Windows.Forms.Padding(3);
            this.tpMojeRezervacije.Size = new System.Drawing.Size(588, 332);
            this.tpMojeRezervacije.TabIndex = 2;
            this.tpMojeRezervacije.Text = "Rezervacije";
            this.tpMojeRezervacije.UseVisualStyleBackColor = true;
            // 
            // btnKorisnikoveRezOdustani
            // 
            this.btnKorisnikoveRezOdustani.Location = new System.Drawing.Point(380, 276);
            this.btnKorisnikoveRezOdustani.Name = "btnKorisnikoveRezOdustani";
            this.btnKorisnikoveRezOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnikoveRezOdustani.TabIndex = 4;
            this.btnKorisnikoveRezOdustani.Text = "Odustani";
            this.btnKorisnikoveRezOdustani.UseVisualStyleBackColor = true;
            this.btnKorisnikoveRezOdustani.Click += new System.EventHandler(this.btnKorisnikoveRezOdustani_Click);
            // 
            // btnKorisnikoveRezervacijeOK
            // 
            this.btnKorisnikoveRezervacijeOK.Location = new System.Drawing.Point(483, 276);
            this.btnKorisnikoveRezervacijeOK.Name = "btnKorisnikoveRezervacijeOK";
            this.btnKorisnikoveRezervacijeOK.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnikoveRezervacijeOK.TabIndex = 3;
            this.btnKorisnikoveRezervacijeOK.Text = "U redu";
            this.btnKorisnikoveRezervacijeOK.UseVisualStyleBackColor = true;
            this.btnKorisnikoveRezervacijeOK.Click += new System.EventHandler(this.btnKorisnikoveRezervacijeOK_Click);
            // 
            // lblVaseRez
            // 
            this.lblVaseRez.AutoSize = true;
            this.lblVaseRez.Location = new System.Drawing.Point(19, 38);
            this.lblVaseRez.Name = "lblVaseRez";
            this.lblVaseRez.Size = new System.Drawing.Size(88, 13);
            this.lblVaseRez.TabIndex = 2;
            this.lblVaseRez.Text = "Vase rezervacije:";
            // 
            // lblUpozorenjeRezevacija
            // 
            this.lblUpozorenjeRezevacija.AutoSize = true;
            this.lblUpozorenjeRezevacija.Location = new System.Drawing.Point(60, 13);
            this.lblUpozorenjeRezevacija.Name = "lblUpozorenjeRezevacija";
            this.lblUpozorenjeRezevacija.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeRezevacija.TabIndex = 1;
            // 
            // lstKorisnickeRez
            // 
            this.lstKorisnickeRez.FormattingEnabled = true;
            this.lstKorisnickeRez.Location = new System.Drawing.Point(113, 38);
            this.lstKorisnickeRez.Name = "lstKorisnickeRez";
            this.lstKorisnickeRez.Size = new System.Drawing.Size(256, 186);
            this.lstKorisnickeRez.TabIndex = 0;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 358);
            this.Controls.Add(this.tbKlijent);
            this.Name = "Rezervacija";
            this.Text = "Rezervacija";
            this.tbKlijent.ResumeLayout(false);
            this.tpSlobonaMesta.ResumeLayout(false);
            this.tpSlobonaMesta.PerformLayout();
            this.tpRezervacijaKarata.ResumeLayout(false);
            this.tpRezervacijaKarata.PerformLayout();
            this.tpMojeRezervacije.ResumeLayout(false);
            this.tpMojeRezervacije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbKlijent;
        private System.Windows.Forms.TabPage tpSlobonaMesta;
        private System.Windows.Forms.Button btnSlobodnaMestaOdustani;
        private System.Windows.Forms.Button btnSlobodnaMestaProjekcija;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.ListBox lstRezultatZaProjekcije;
        private System.Windows.Forms.ComboBox cmbProjekcije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpozorenjeSlobodnaMesta;
        private System.Windows.Forms.TabPage tpRezervacijaKarata;
        private System.Windows.Forms.TabPage tpMojeRezervacije;
        private System.Windows.Forms.Button btnPreuzmiProjekcije;
        private System.Windows.Forms.Button btnKorisnikoveRezOdustani;
        private System.Windows.Forms.Button btnKorisnikoveRezervacijeOK;
        private System.Windows.Forms.Label lblVaseRez;
        private System.Windows.Forms.Label lblUpozorenjeRezevacija;
        private System.Windows.Forms.ListBox lstKorisnickeRez;
        private System.Windows.Forms.Button btnPreuzmiProj;
        private System.Windows.Forms.ComboBox cmbSveProjekcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpoRez;
        private System.Windows.Forms.Button btnOdustaniRezervacija;
        private System.Windows.Forms.Button btnRezervisi;
    }
}