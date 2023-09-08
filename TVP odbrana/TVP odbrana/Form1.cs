using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_odbrana
{
    public partial class Form1 : Form
    {
        List<Korisnik> korisnici;
        String nazivDatoteke = "Korisnici.bin";
        Korisnik trenutniKorisnik = new Korisnik();

        public Form1()
        {
            InitializeComponent();
            korisnici = new List<Korisnik>();
            FileStream tok = File.Open(nazivDatoteke, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            korisnici = bf.Deserialize(tok) as List<Korisnik>;
            tok.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {  

            try
            {
               

                if (txtLogKIme.Text != "" && txtLogLozinka.Text != "")
                {
                    foreach (Korisnik k in korisnici)
                    {
                        if (k.ImeKorisnika == txtLogKIme.Text && k.Lozinka == txtLogLozinka.Text)
                        {
                            trenutniKorisnik = k;
                        }
                    }
                    if (trenutniKorisnik.ImeKorisnika == "admin")
                    {
                        Form frm1 = new Admin();
                        frm1.Show();
                    }
                    else if (trenutniKorisnik.ImeKorisnika != "")
                    {
                        Form frm2 = new Klijent();
                        frm2.Show();
                    }
                    else
                        MessageBox.Show("Uneli ste pogresnu lozinku, korisnicko ime ili niste registrovani");
                }
                else
                    MessageBox.Show("Niste uneli loziknku ili korisnicko ime");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegIme.Text != "" && txtRegPrezime.Text != "" && txtRegKorIme.Text != "" && txtRegLozinka.Text != "" && txtRegLozinka.Text == txtRegLozinka2.Text)
            {
                korisnici.Add(new Korisnik(txtRegIme.Text, txtRegPrezime.Text, txtRegKorIme.Text, txtRegLozinka.Text));
                FileStream tok = File.Open(nazivDatoteke, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(tok, korisnici);
                tok.Close();
            }
            else
                MessageBox.Show("Niste uneli sve linije teksta ili se lozinke ne poklapaju");
        }
    }
}
