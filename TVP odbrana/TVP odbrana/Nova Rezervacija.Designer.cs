namespace TVP_odbrana
{
    partial class Nova_Rezervacija
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
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.cmbJela = new System.Windows.Forms.ComboBox();
            this.listVewRestorani = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KontaktTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(452, 68);
            this.btnIzaberi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(140, 49);
            this.btnIzaberi.TabIndex = 5;
            this.btnIzaberi.Text = "Izaberi restoran";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // cmbJela
            // 
            this.cmbJela.FormattingEnabled = true;
            this.cmbJela.Location = new System.Drawing.Point(452, 30);
            this.cmbJela.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJela.Name = "cmbJela";
            this.cmbJela.Size = new System.Drawing.Size(140, 21);
            this.cmbJela.TabIndex = 4;
            // 
            // listVewRestorani
            // 
            this.listVewRestorani.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Adresa,
            this.KontaktTelefon});
            this.listVewRestorani.HideSelection = false;
            this.listVewRestorani.Location = new System.Drawing.Point(86, 30);
            this.listVewRestorani.Margin = new System.Windows.Forms.Padding(2);
            this.listVewRestorani.Name = "listVewRestorani";
            this.listVewRestorani.Size = new System.Drawing.Size(307, 390);
            this.listVewRestorani.TabIndex = 3;
            this.listVewRestorani.UseCompatibleStateImageBehavior = false;
            this.listVewRestorani.View = System.Windows.Forms.View.Details;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 150;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 150;
            // 
            // KontaktTelefon
            // 
            this.KontaktTelefon.Text = "Kontakt Telefon";
            this.KontaktTelefon.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izaberi restoran";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(452, 136);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Izaberi restoran";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(452, 247);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // Nova_Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.cmbJela);
            this.Controls.Add(this.listVewRestorani);
            this.Name = "Nova_Rezervacija";
            this.Text = "Nova_Rezervacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.ComboBox cmbJela;
        private System.Windows.Forms.ListView listVewRestorani;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader KontaktTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}