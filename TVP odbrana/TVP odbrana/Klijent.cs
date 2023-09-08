using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_odbrana
{
    public partial class Klijent : Form
    {
        public Klijent()
        {
            InitializeComponent();
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nova_Rezervacija novaRez = new Nova_Rezervacija();
            novaRez.Show();
            novaRez.Closed += delegate { this.Close(); };
        }

        
    }
}
