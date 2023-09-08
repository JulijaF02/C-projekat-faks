namespace TVP_odbrana
{
    partial class Klijent
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
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restoran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prilog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodatak1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodatak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodatak3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(598, 322);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(126, 23);
            this.btnDetalji.TabIndex = 11;
            this.btnDetalji.Text = "Detalji rezervacije";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(242, 322);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(126, 23);
            this.btnPromeni.TabIndex = 10;
            this.btnPromeni.Text = "Promeni rezervaciju";
            this.btnPromeni.UseVisualStyleBackColor = true;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(52, 322);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(126, 23);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "Brisi rezervaciju";
            this.btnBrisi.UseVisualStyleBackColor = true;
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Location = new System.Drawing.Point(416, 322);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(126, 23);
            this.btnNovaRezervacija.TabIndex = 7;
            this.btnNovaRezervacija.Text = "Nova rezervacija";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Restoran,
            this.Jelo,
            this.Prilog,
            this.Dodatak1,
            this.Dodatak2,
            this.Dodatak3,
            this.Korisnik});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 279);
            this.dataGridView1.TabIndex = 12;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Restoran
            // 
            this.Restoran.HeaderText = "Restoran";
            this.Restoran.Name = "Restoran";
            // 
            // Jelo
            // 
            this.Jelo.HeaderText = "Jelo";
            this.Jelo.Name = "Jelo";
            // 
            // Prilog
            // 
            this.Prilog.HeaderText = "Prilog";
            this.Prilog.Name = "Prilog";
            // 
            // Dodatak1
            // 
            this.Dodatak1.HeaderText = "Dodatak1";
            this.Dodatak1.Name = "Dodatak1";
            // 
            // Dodatak2
            // 
            this.Dodatak2.HeaderText = "Dodatak2";
            this.Dodatak2.Name = "Dodatak2";
            // 
            // Dodatak3
            // 
            this.Dodatak3.HeaderText = "Dodatak3";
            this.Dodatak3.Name = "Dodatak3";
            // 
            // Korisnik
            // 
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // Klijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnNovaRezervacija);
            this.Name = "Klijent";
            this.Text = "Klijent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restoran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prilog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dodatak1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dodatak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dodatak3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
    }
}