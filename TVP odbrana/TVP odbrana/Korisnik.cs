using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_odbrana
{
    public class Korisnik
    {
        
        public Guid Id { get; set; }    
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string VrstaKorisnika { get; set; }

        public List<Korisnik> Korisnici { get; set; }

        const string KorisnikDB = "D:\\TVP odbrana\\bazaKorisnici.csv";
        public Korisnik()
        {

        }

        public Korisnik(Guid id, string imeKorisnika, string prezimeKorisnika, string korisnickoIme, string lozinka, string vrstaKorisnika)
        {
            Id = id;
            this.ImeKorisnika = imeKorisnika;
            this.PrezimeKorisnika = prezimeKorisnika;
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
            this.VrstaKorisnika = vrstaKorisnika;
        }

        public void dodajKorisnika(DataGridView dgKorisnici, string imeKorisnika, string prezimeKorisnika, string korisnickoIme, string lozinka, string vrstaKorisnika)
        {
            try
            {
                if(string.IsNullOrEmpty(imeKorisnika)|| string.IsNullOrEmpty(imeKorisnika)|| string.IsNullOrEmpty(prezimeKorisnika)|| string.IsNullOrEmpty(korisnickoIme)|| string.IsNullOrEmpty(lozinka)|| string.IsNullOrEmpty(vrstaKorisnika)) 
                {
                    MessageBox.Show("Niste popunili sva polja!", "Input data is not correct!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (imeKorisnika.Length < 3)
                {
                    MessageBox.Show("Ime restorana je previse kratko!", "Name not in correct format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var korisnik = new Korisnik(Id, imeKorisnika, prezimeKorisnika, korisnickoIme, lozinka, vrstaKorisnika);
                Korisnici.Add(korisnik);

                sacuvajKorisnike();
                ucitajKorisnike(dgKorisnici);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Korisnik> ucitajKorisnike(DataGridView dgKorisnici)
        {

            Korisnici = new List<Korisnik>();

            try
            {
                string[] korisnikLista = File.ReadAllLines(KorisnikDB);
                foreach (var korisnikLine in korisnikLista)
                {
                    string[] korisnikData = korisnikLine.Split(';');
                    if (korisnikData.Length < 6)
                    {
                        continue;
                    }
                    Guid userId = Guid.Parse(korisnikData[0]);
                    string imeKorisnika = korisnikData[1];
                    string prezimeKorisnika = korisnikData[2];
                    string korisnickoIme = korisnikData[3];
                    string lozinka = korisnikData[4];
                    string vrstaKorisnika = korisnikData[5];
                    var korisnik = new Korisnik(userId, imeKorisnika, prezimeKorisnika, korisnickoIme, lozinka, vrstaKorisnika);
                    Korisnici.Add(korisnik);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgKorisnici.DataSource = null;
            dgKorisnici.DataSource = Korisnici;
            return Korisnici;
        }

        public void sacuvajKorisnike()
        {
            try
            {
                List<string> korisniciLines = new List<string>();
                foreach (Korisnik k in Korisnici)
                {
                    string korisnikLine = $"{k.Id};{k.ImeKorisnika};{k.PrezimeKorisnika};{k.KorisnickoIme};{k.Lozinka};{k.VrstaKorisnika}";
                    korisniciLines.Add(korisnikLine);
                }
                File.WriteAllLines(KorisnikDB, korisniciLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void obrisiKorisnika(DataGridView dgKorisnik)
        {
            try
            {
                if (dgKorisnik.SelectedRows.Count > 0)
                {
                    DataGridViewRow korisnikRow = dgKorisnik.SelectedRows[0];
                    var nadjenKorisnik = korisnikRow.DataBoundItem as Korisnik; //Razumeti


                    var korisnikUListi = Korisnici.Where(x => x.Id == nadjenKorisnik.Id).FirstOrDefault(); //u slucaju da je lista prazna bice NULL (FirstOrDefault)
                    if (korisnikUListi != null)
                    {
                        Korisnici.Remove(korisnikUListi);
                    }


                }
                sacuvajKorisnike();
                ucitajKorisnike(dgKorisnik);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public void AzurirajKorisnike(DataGridView dgKorisnik, Korisnik SelectedKorisnik, string imeKorisnika, string prezimeKorisnika, string korisnickoIme, string lozinka, string vrstaKorisnika)
        {

            if (SelectedKorisnik == null)
            {
                return;
            }
            var korisnik = Korisnici.Where(x => x.Id == SelectedKorisnik.Id).FirstOrDefault();
            if (korisnik == null)
            {
                return;
            }

            korisnik.ImeKorisnika = imeKorisnika;
            korisnik.PrezimeKorisnika = prezimeKorisnika;
            korisnik.KorisnickoIme = korisnickoIme;
            korisnik.Lozinka = lozinka;
            korisnik.VrstaKorisnika = vrstaKorisnika;

            if (string.IsNullOrEmpty(imeKorisnika) || string.IsNullOrEmpty(prezimeKorisnika) || string.IsNullOrEmpty(korisnickoIme)|| string.IsNullOrEmpty(lozinka)|| string.IsNullOrEmpty(vrstaKorisnika))
            {
                MessageBox.Show("Niste popunili sva polja!", "Input data is not correct!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            dgKorisnik.ClearSelection();
            sacuvajKorisnike();
            ucitajKorisnike(dgKorisnik);
        }
    }

    
}
