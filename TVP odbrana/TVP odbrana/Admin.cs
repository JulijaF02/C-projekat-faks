using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_odbrana
{
    public partial class Admin : Form
    {
        //OBJEKTI
        Restoran restoran = new Restoran();

        Prilog prilog = new Prilog();

        Jelo jelo = new Jelo();

        Dodatak dodatak = new Dodatak();    

        Korisnik korisnik = new Korisnik(); 

        //Properties
        public Restoran SelectedRestoran { get; set; }

        public Prilog SelectedPrilog { get; set; }

        public Jelo SelectedJelo    { get; set; }

        public Dodatak SelectedDodatak { get; set; }

        public Korisnik SelectedKorisnik { get; set; }  

        

        public Admin()
        {
            InitializeComponent();
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            try
            {
                restoran.UcitajRestorane(dgRestoran);
                prilog.UcitajPriloge(dgPrilog);
                jelo.UcitajJela(dgJelo);
                dodatak.UcitajDodatke(dgDodatak);
                korisnik.ucitajKorisnike(dgKorisnik);

                

                cmbRestoran.DataSource = restoran.UcitajRestorane(dgRestoran);
                cmbRestoran.DisplayMember = "Id";
                
                cmbPrilog.DataSource = prilog.UcitajPriloge(dgPrilog);
                cmbPrilog.DisplayMember = "Id";

                
                cmbVrstaKorisnika.Items.Add("Admin");
                cmbVrstaKorisnika.Items.Add("Klijent");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------KOD ZA RESTORAN----------
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                restoran.Dodaj(dgRestoran, txtNaziv.Text, txtAdresa.Text, txtTelefon.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisiRestoran_Click(object sender, EventArgs e)
        {
            restoran.ObrisiRestoran(dgRestoran);
        }

        private void dgRestoran_SelectionChanged(object sender, EventArgs e) // pokazuje mi u textboxu podatke
        {
            if (dgRestoran.SelectedRows.Count > 0)
            {

                DataGridViewRow restoranRow = dgRestoran.SelectedRows[0];
                var nadjenRestoran = restoranRow.DataBoundItem as Restoran;
                SelectedRestoran = nadjenRestoran;

                txtNaziv.Text = SelectedRestoran.NazivRestorana;
                txtAdresa.Text = SelectedRestoran.Adresa;
                txtTelefon.Text = SelectedRestoran.Telefon;
            }
        }

        private void btnAzururajRestoran_Click(object sender, EventArgs e)
        {
            restoran.AzurirajRestoran(dgRestoran, SelectedRestoran,txtNaziv.Text, txtAdresa.Text, txtTelefon.Text);
        }



        //-----KOD ZA PRILOG--------------

        private void btnAddPrilog_Click(object sender, EventArgs e)
        {
            try
            {
                prilog.DodajPrilog(dgPrilog, txtNazivPriloga.Text, txtCenaPriloga.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePrilog_Click(object sender, EventArgs e)
        {
            try
            {
                prilog.ObrisiPrilog(dgPrilog);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePrilog_Click(object sender, EventArgs e)
        {
            try
            {
                prilog.AzurirajPriloge(dgPrilog, SelectedPrilog, txtNazivPriloga.Text, txtCenaPriloga.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgPrilog_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgPrilog.SelectedRows.Count > 0)
                {

                    DataGridViewRow prilogRow = dgPrilog.SelectedRows[0];
                    var nadjenPrilog = prilogRow.DataBoundItem as Prilog;
                    SelectedPrilog = nadjenPrilog;

                    txtNazivPriloga.Text = SelectedPrilog.NazivPriloga;
                    txtCenaPriloga.Text = SelectedPrilog.Cena;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        //kod za jelo
        private void btnAddJelo_Click_1(object sender, EventArgs e)
        {
            try
            { 
                jelo.DodajJelo(dgJelo, txtNazivJela.Text, txtGramazaJela.Text, txtOpisJela.Text, txtDodaciJela.Text, Guid.Parse(cmbRestoran.Text), Guid.Parse(cmbPrilog.Text),int.Parse(txtCenaJela.Text)); 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateJelo_Click(object sender, EventArgs e)
        {
            try
            {
                jelo.AzurirajJelo(dgJelo, SelectedJelo, txtNazivJela.Text, txtGramazaJela.Text, txtOpisJela.Text, txtDodaciJela.Text, Guid.Parse(cmbRestoran.Text), Guid.Parse(cmbPrilog.Text),int.Parse(txtCenaJela.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgJelo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgJelo.SelectedRows.Count > 0)
                {

                    DataGridViewRow jeloRow = dgJelo.SelectedRows[0];
                    var nadjenoJelo = jeloRow.DataBoundItem as Jelo;
                    SelectedJelo = nadjenoJelo;

                    txtNazivJela.Text = SelectedJelo.NazivJela;
                    txtDodaciJela.Text = SelectedJelo.Dodaci;
                    txtCenaJela.Text = SelectedDodatak.Cena.ToString();
                    txtGramazaJela.Text = SelectedJelo.Gramaza;
                    txtOpisJela.Text = SelectedJelo.OpisJela;
                    cmbPrilog.Text = SelectedJelo.PrilogId.ToString();
                    cmbRestoran.Text = SelectedJelo.RestoranId.ToString();  
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveJelo_Click(object sender, EventArgs e)
        {
            try
            {
                jelo.ObrisiJelo(dgJelo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kod za dodatak
        private void btnAddDodatak_Click(object sender, EventArgs e)
        {
            try
            {
                dodatak.DodajDodatak(dgDodatak, txtNazivDodatka.Text, int.Parse(txtCenaDodatka.Text), int.Parse(txtGramazaDodatka.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDodatak_Click(object sender, EventArgs e)
        {
            try
            {
                dodatak.AzurirajDodatke(dgDodatak, SelectedDodatak,txtNazivDodatka.Text, int.Parse(txtCenaDodatka.Text), int.Parse(txtGramazaDodatka.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDodatak_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgDodatak.SelectedRows.Count > 0)
                {

                    DataGridViewRow dodatakRow = dgDodatak.SelectedRows[0];
                    var nadjenDodatak = dodatakRow.DataBoundItem as Dodatak;
                    SelectedDodatak = nadjenDodatak;

                    txtNazivDodatka.Text = SelectedDodatak.NazivDodatka;
                    txtCenaDodatka.Text = SelectedDodatak.Cena.ToString();
                    txtGramazaDodatka.Text = SelectedDodatak.Gramaza.ToString();
                    



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDodatak_Click(object sender, EventArgs e)
        {
            try
            {
                dodatak.ObrisiDodatak(dgDodatak);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kod za korisnike
        private void btnAddKorisnik_Click(object sender, EventArgs e)
        {
            try
            {
                korisnik.dodajKorisnika(dgKorisnik, txtNazivKorisnika.Text, txtPrezimeKorisnika.Text, txtKorisnickoIme.Text, txtLozinka.Text, cmbVrstaKorisnika.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateKorisnik_Click(object sender, EventArgs e)
        {
            try
            {
                korisnik.AzurirajKorisnike(dgKorisnik, SelectedKorisnik, txtNazivKorisnika.Text,txtPrezimeKorisnika.Text, txtKorisnickoIme.Text, txtLozinka.Text, cmbVrstaKorisnika.Text );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveKorisnik_Click(object sender, EventArgs e)
        {

        }

        private void dgKorisnik_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgKorisnik.SelectedRows.Count > 0)
                {

                    DataGridViewRow korisnikRow = dgKorisnik.SelectedRows[0];
                    var nadjenKorisnik = korisnikRow.DataBoundItem as Korisnik;
                    SelectedKorisnik = nadjenKorisnik;

                    txtNazivKorisnika.Text = SelectedKorisnik.ImeKorisnika;
                    txtPrezimeKorisnika.Text = SelectedKorisnik.PrezimeKorisnika;
                    txtKorisnickoIme.Text = SelectedKorisnik.KorisnickoIme;
                    txtLozinka.Text = SelectedKorisnik.Lozinka;
                    
                    




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
