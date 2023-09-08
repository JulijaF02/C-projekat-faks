using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_odbrana
{
    public class Dodatak
    {
        public Guid Id { get; set; }   
        public string NazivDodatka { get; set; }
        public int Cena { get; set; }
        public int Gramaza { get; set; }

        const string DodatakDB = "D:\\TVP odbrana\\bazaDodatak.csv";
        public List<Dodatak> Dodaci { get; set; }


        public Dodatak(Guid id, string nazivDodatka, int cena, int gramaza)
        {
            Id = id;
            NazivDodatka = nazivDodatka;
            Cena = cena;    
            Gramaza = gramaza;
        }

        public Dodatak()
        {

        }

       

        public void DodajDodatak(DataGridView dgDodatak, string naziv, int cena, int gramaza)
        {
            try
            {

                if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(cena.ToString()) || string.IsNullOrEmpty(gramaza.ToString()))
                {
                    MessageBox.Show("Niste popunili sva polja!", "Input data is not correct!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (naziv.Length < 3)
                {
                    MessageBox.Show("Ime dodatka je previse kratko!", "Name not in correct format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dodatak = new Dodatak(Guid.NewGuid(), naziv, cena, gramaza);
                Dodaci.Add(dodatak);


                SacuvajDodatke();
                UcitajDodatke(dgDodatak);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Dodatak> UcitajDodatke(DataGridView dgDodatak)
        {
            Dodaci = new List<Dodatak>();
            try
            {
                string[] dodatakLista = File.ReadAllLines(DodatakDB);
                foreach (var dodatakLine in dodatakLista)
                {
                    string[] dodatakData = dodatakLine.Split(';');
                    if (dodatakData.Length < 4) //ako slucajno dodamo podatak u fajl, Ne zelimo da ga citamo!
                    {
                        continue;
                    }
                    Guid userId = Guid.Parse(dodatakData[0]);
                    string nazivDodatka = dodatakData[1];
                    int cena = int.Parse(dodatakData[2]);
                    int gramaza = int.Parse(dodatakData[3]);

                    var dodatak = new Dodatak(userId, nazivDodatka, cena, gramaza);
                    Dodaci.Add(dodatak);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgDodatak.DataSource = null;
            dgDodatak.DataSource = Dodaci;

            return Dodaci;

        }


        public void SacuvajDodatke()
        {
            try
            {
                List<string> dodaciLines = new List<string>();
                foreach (Dodatak d in Dodaci)
                {
                    string dodatakLine = $"{d.Id};{d.NazivDodatka};{d.Cena};{d.Gramaza}";
                    dodaciLines.Add(dodatakLine);
                }
                File.WriteAllLines(DodatakDB, dodaciLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "An unexpected error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObrisiDodatak(DataGridView dgDodatak)
        {
            if (dgDodatak.SelectedRows.Count > 0)
            {
                DataGridViewRow dodatakRow = dgDodatak.SelectedRows[0];
                var nadjenDodatak = dodatakRow.DataBoundItem as Dodatak; //Razumeti


                var dodatakUListi = Dodaci.Where(x => x.Id == nadjenDodatak.Id).FirstOrDefault(); //u slucaju da je lista prazna bice NULL (FirstOrDefault)
                if (dodatakUListi != null)
                {
                    Dodaci.Remove(dodatakUListi);
                }


            }
            SacuvajDodatke();
            UcitajDodatke(dgDodatak);
        }

        public void AzurirajDodatke(DataGridView dgDodatak, Dodatak SelectedDodatak, string nazivDodatka, int cena, int gramaza)
        {

            if (SelectedDodatak == null)
            {
                return;
            }
            var dodatak = Dodaci.Where(x => x.Id == SelectedDodatak.Id).FirstOrDefault();
            if (dodatak == null)
            {
                return;
            }

            dodatak.NazivDodatka = nazivDodatka;
            dodatak.Cena = cena;
            dodatak.Gramaza = gramaza;


            dgDodatak.ClearSelection();
            SacuvajDodatke();
            UcitajDodatke(dgDodatak);
        }


    }
}
