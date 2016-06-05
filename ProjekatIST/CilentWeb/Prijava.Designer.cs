namespace CilentWeb
{
    partial class Prijava
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
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbKorisnik = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(76, 81);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword.TabIndex = 7;
            // 
            // txtbKorisnik
            // 
            this.txtbKorisnik.Location = new System.Drawing.Point(76, 36);
            this.txtbKorisnik.Name = "txtbKorisnik";
            this.txtbKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtbKorisnik.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(143, 132);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "U redu";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.AutoSize = true;
            this.lblUpozorenje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUpozorenje.Location = new System.Drawing.Point(64, 9);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenje.TabIndex = 8;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 181);
            this.Controls.Add(this.lblUpozorenje);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbKorisnik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOk);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbKorisnik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblUpozorenje;
    }
}

