namespace Forme
{
    partial class DodajIzmeniKoncertForma
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
            labelNaziv = new Label();
            labelzvodjac = new Label();
            labelLokacija = new Label();
            labelDatum = new Label();
            labelVremePocetka = new Label();
            labelTrajanje = new Label();
            labelStatus = new Label();
            textBoxNaziv = new TextBox();
            comboBoxLokacija = new ComboBox();
            comboBoxStatus = new ComboBox();
            dateTimePickerDatum = new DateTimePicker();
            dateTimePickerVremePocetka = new DateTimePicker();
            numericUpDownTrajanje = new NumericUpDown();
            comboBoxIzvodjac = new ComboBox();
            buttonDodaj = new Button();
            buttonIzmeni = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrajanje).BeginInit();
            SuspendLayout();
            // 
            // labelNaziv
            // 
            labelNaziv.AutoSize = true;
            labelNaziv.Location = new Point(39, 39);
            labelNaziv.Name = "labelNaziv";
            labelNaziv.Size = new Size(132, 25);
            labelNaziv.TabIndex = 0;
            labelNaziv.Text = "Naziv koncerta:";
            // 
            // labelzvodjac
            // 
            labelzvodjac.AutoSize = true;
            labelzvodjac.Location = new Point(64, 90);
            labelzvodjac.Name = "labelzvodjac";
            labelzvodjac.Size = new Size(73, 25);
            labelzvodjac.TabIndex = 1;
            labelzvodjac.Text = "Izvođač";
            // 
            // labelLokacija
            // 
            labelLokacija.AutoSize = true;
            labelLokacija.Location = new Point(63, 146);
            labelLokacija.Name = "labelLokacija";
            labelLokacija.Size = new Size(74, 25);
            labelLokacija.TabIndex = 2;
            labelLokacija.Text = "Lokacija";
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(66, 214);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(70, 25);
            labelDatum.TabIndex = 3;
            labelDatum.Text = "Datum:";
            // 
            // labelVremePocetka
            // 
            labelVremePocetka.AutoSize = true;
            labelVremePocetka.Location = new Point(39, 277);
            labelVremePocetka.Name = "labelVremePocetka";
            labelVremePocetka.Size = new Size(134, 25);
            labelVremePocetka.TabIndex = 4;
            labelVremePocetka.Text = "Vreme početka:";
            // 
            // labelTrajanje
            // 
            labelTrajanje.AutoSize = true;
            labelTrajanje.Location = new Point(23, 329);
            labelTrajanje.Name = "labelTrajanje";
            labelTrajanje.Size = new Size(175, 25);
            labelTrajanje.TabIndex = 5;
            labelTrajanje.Text = "Trajanje (u minutima)";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(76, 391);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(60, 25);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Status";
            // 
            // textBoxNaziv
            // 
            textBoxNaziv.Location = new Point(221, 39);
            textBoxNaziv.Name = "textBoxNaziv";
            textBoxNaziv.Size = new Size(312, 31);
            textBoxNaziv.TabIndex = 7;
            // 
            // comboBoxLokacija
            // 
            comboBoxLokacija.FormattingEnabled = true;
            comboBoxLokacija.Location = new Point(226, 146);
            comboBoxLokacija.Name = "comboBoxLokacija";
            comboBoxLokacija.Size = new Size(307, 33);
            comboBoxLokacija.TabIndex = 8;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(221, 390);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(307, 33);
            comboBoxStatus.TabIndex = 9;
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Format = DateTimePickerFormat.Short;
            dateTimePickerDatum.Location = new Point(221, 214);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(312, 31);
            dateTimePickerDatum.TabIndex = 12;
            // 
            // dateTimePickerVremePocetka
            // 
            dateTimePickerVremePocetka.CustomFormat = "HH:mm";
            dateTimePickerVremePocetka.Format = DateTimePickerFormat.Time;
            dateTimePickerVremePocetka.Location = new Point(221, 278);
            dateTimePickerVremePocetka.Name = "dateTimePickerVremePocetka";
            dateTimePickerVremePocetka.ShowUpDown = true;
            dateTimePickerVremePocetka.Size = new Size(307, 31);
            dateTimePickerVremePocetka.TabIndex = 13;
            // 
            // numericUpDownTrajanje
            // 
            numericUpDownTrajanje.Location = new Point(221, 337);
            numericUpDownTrajanje.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDownTrajanje.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTrajanje.Name = "numericUpDownTrajanje";
            numericUpDownTrajanje.Size = new Size(307, 31);
            numericUpDownTrajanje.TabIndex = 14;
            numericUpDownTrajanje.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxIzvodjac
            // 
            comboBoxIzvodjac.FormattingEnabled = true;
            comboBoxIzvodjac.Location = new Point(226, 87);
            comboBoxIzvodjac.Name = "comboBoxIzvodjac";
            comboBoxIzvodjac.Size = new Size(307, 33);
            comboBoxIzvodjac.TabIndex = 15;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(639, 214);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(112, 34);
            buttonDodaj.TabIndex = 16;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // buttonIzmeni
            // 
            buttonIzmeni.Location = new Point(639, 275);
            buttonIzmeni.Name = "buttonIzmeni";
            buttonIzmeni.Size = new Size(112, 34);
            buttonIzmeni.TabIndex = 17;
            buttonIzmeni.Text = "Izmeni";
            buttonIzmeni.UseVisualStyleBackColor = true;
            buttonIzmeni.Click += buttonIzmeni_Click;
            // 
            // DodajIzmeniKoncertForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 496);
            Controls.Add(buttonIzmeni);
            Controls.Add(buttonDodaj);
            Controls.Add(comboBoxIzvodjac);
            Controls.Add(numericUpDownTrajanje);
            Controls.Add(dateTimePickerVremePocetka);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxLokacija);
            Controls.Add(textBoxNaziv);
            Controls.Add(labelStatus);
            Controls.Add(labelTrajanje);
            Controls.Add(labelVremePocetka);
            Controls.Add(labelDatum);
            Controls.Add(labelLokacija);
            Controls.Add(labelzvodjac);
            Controls.Add(labelNaziv);
            Name = "DodajIzmeniKoncertForma";
            Text = "DodajIzmeniKocertForma";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTrajanje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNaziv;
        private Label labelzvodjac;
        private Label labelLokacija;
        private Label labelDatum;
        private Label labelVremePocetka;
        private Label labelTrajanje;
        private Label labelStatus;
        private TextBox textBoxNaziv;
        private ComboBox comboBoxLokacija;
        private ComboBox comboBoxStatus;
        private DateTimePicker dateTimePickerDatum;
        private DateTimePicker dateTimePickerVremePocetka;
        private NumericUpDown numericUpDownTrajanje;
        private ComboBox comboBoxIzvodjac;
        private Button buttonDodaj;
        private Button buttonIzmeni;
    }
}