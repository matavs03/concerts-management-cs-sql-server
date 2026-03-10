namespace Forme
{
    partial class IzvođačDetaljiForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;

        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;

        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.ComboBox cmbPol;

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;

        private System.Windows.Forms.Label lblBrojClanova;
        private System.Windows.Forms.NumericUpDown numBrojClanova;

        private System.Windows.Forms.Label lblZanrovi;
        private System.Windows.Forms.CheckedListBox clbZanrovi;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
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
            lblNaslov = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblPol = new Label();
            cmbPol = new ComboBox();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblBrojClanova = new Label();
            numBrojClanova = new NumericUpDown();
            lblZanrovi = new Label();
            clbZanrovi = new CheckedListBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)numBrojClanova).BeginInit();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNaslov.Location = new Point(30, 20);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(158, 20);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Unos podataka";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(30, 100);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 3;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(150, 97);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(220, 23);
            txtIme.TabIndex = 4;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(30, 140);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(56, 15);
            lblPrezime.TabIndex = 5;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(150, 137);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(220, 23);
            txtPrezime.TabIndex = 6;
            // 
            // lblPol
            // 
            lblPol.AutoSize = true;
            lblPol.Location = new Point(30, 180);
            lblPol.Name = "lblPol";
            lblPol.Size = new Size(25, 15);
            lblPol.TabIndex = 7;
            lblPol.Text = "Pol:";
            // 
            // cmbPol
            // 
            cmbPol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPol.FormattingEnabled = true;
            cmbPol.Location = new Point(150, 177);
            cmbPol.Name = "cmbPol";
            cmbPol.Size = new Size(220, 23);
            cmbPol.TabIndex = 8;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(30, 100);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(41, 15);
            lblNaziv.TabIndex = 9;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(150, 97);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(220, 23);
            txtNaziv.TabIndex = 10;
            // 
            // lblBrojClanova
            // 
            lblBrojClanova.AutoSize = true;
            lblBrojClanova.Location = new Point(30, 140);
            lblBrojClanova.Name = "lblBrojClanova";
            lblBrojClanova.Size = new Size(79, 15);
            lblBrojClanova.TabIndex = 11;
            lblBrojClanova.Text = "Broj članova:";
            // 
            // numBrojClanova
            // 
            numBrojClanova.Location = new Point(150, 137);
            numBrojClanova.Name = "numBrojClanova";
            numBrojClanova.Size = new Size(220, 23);
            numBrojClanova.TabIndex = 12;
            // 
            // lblZanrovi
            // 
            lblZanrovi.AutoSize = true;
            lblZanrovi.Location = new Point(30, 225);
            lblZanrovi.Name = "lblZanrovi";
            lblZanrovi.Size = new Size(49, 15);
            lblZanrovi.TabIndex = 13;
            lblZanrovi.Text = "Žanrovi:";
            // 
            // clbZanrovi
            // 
            clbZanrovi.CheckOnClick = true;
            clbZanrovi.FormattingEnabled = true;
            clbZanrovi.Location = new Point(150, 225);
            clbZanrovi.Name = "clbZanrovi";
            clbZanrovi.Size = new Size(220, 112);
            clbZanrovi.TabIndex = 14;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(150, 355);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 35);
            btnSacuvaj.TabIndex = 15;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(270, 355);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(100, 35);
            btnOdustani.TabIndex = 16;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // IzvodjacDetaljiForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 420);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(clbZanrovi);
            Controls.Add(lblZanrovi);
            Controls.Add(numBrojClanova);
            Controls.Add(lblBrojClanova);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(cmbPol);
            Controls.Add(lblPol);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblIme);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNaslov);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzvodjacDetaljiForma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalji izvođača";
            Load += IzvodjacDetaljiForma_Load;
            ((System.ComponentModel.ISupportInitialize)numBrojClanova).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}