using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class DodajIzmeniKoncertForma : Form
    {
        private Koncert koncertZaIzmenu;
        public DodajIzmeniKoncertForma()
        {
            InitializeComponent();
            InicijalizujFormu();

            this.Text = "Dodaj koncert";
            buttonDodaj.Visible = true;
            buttonIzmeni.Visible = false;

        }
        public DodajIzmeniKoncertForma(Koncert koncert) : this()
        {
            koncertZaIzmenu = koncert;
            PopuniPolja(koncert);

            comboBoxIzvodjac.Enabled = false;
            comboBoxLokacija.Enabled = false;

            this.Text = "Izmeni koncert";
            buttonDodaj.Visible = false;
            buttonIzmeni.Visible = true;
        }

        private void InicijalizujFormu()
        {
            
            comboBoxStatus.DataSource = Enum.GetValues(typeof(Status));
            UcitajIzvodjace();
            UcitajLokacije();

            dateTimePickerVremePocetka.Value = DateTime.Today.AddHours(20);
            
        }

        private void UcitajLokacije()
        {
            List<Lokacija> lokacije = Kontroler.Kontroler.Instance.VratiSveLokacije();
            comboBoxLokacija.DataSource = lokacije;
        }

        private void UcitajIzvodjace()
        {
            List<Izvodjac> izvodjaci = Kontroler.Kontroler.Instance.VratiSveIzvodjacePrikaz();
            comboBoxIzvodjac.DataSource = izvodjaci;
        }

        private void PopuniPolja(Koncert koncert)
        {
            textBoxNaziv.Text = koncert.Naziv;
            
            dateTimePickerDatum.Value = koncert.Datum;
            dateTimePickerVremePocetka.Value = DateTime.Today.Add(koncert.VremePocetka);
            numericUpDownTrajanje.Value = koncert.VremeTrajanja;
            comboBoxStatus.SelectedItem = koncert.Status;

            for (int i = 0; i < comboBoxIzvodjac.Items.Count; i++)
            {
                Izvodjac iz = (Izvodjac)comboBoxIzvodjac.Items[i];
                if (iz.Id == koncert.izvodjac.Id)
                {
                    comboBoxIzvodjac.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < comboBoxLokacija.Items.Count; i++)
            {
                Lokacija lok = (Lokacija)comboBoxLokacija.Items[i];
                if (lok.LokacijaId == koncert.lokacija.LokacijaId)
                {
                    comboBoxLokacija.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv koncerta.");
                    return;
                }

                Izvodjac izabraniIzvodjac = (Izvodjac)comboBoxIzvodjac.SelectedItem;
                Lokacija izabranaLokacija = (Lokacija)comboBoxLokacija.SelectedItem;
                Status status = (Status)comboBoxStatus.SelectedItem;

                Koncert koncert = new Koncert
                {
                    Naziv = textBoxNaziv.Text.Trim(),
                    izvodjac = izabraniIzvodjac,
                    lokacija = izabranaLokacija,
                    Datum = dateTimePickerDatum.Value.Date,
                    VremePocetka = dateTimePickerVremePocetka.Value.TimeOfDay,
                    VremeTrajanja = (int)numericUpDownTrajanje.Value,
                    Status = status
                };

                Kontroler.Kontroler.Instance.SacuvajKoncert(koncert);

                MessageBox.Show("Koncert je uspešno dodat.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Izvodjac izvodjac = (Izvodjac)comboBoxIzvodjac.SelectedItem;
                Lokacija lokacija = (Lokacija)comboBoxLokacija.SelectedItem;
                Status status = (Status)comboBoxStatus.SelectedItem;

                TimeSpan vreme = new TimeSpan(
                    dateTimePickerVremePocetka.Value.Hour,
                    dateTimePickerVremePocetka.Value.Minute,
                    0
                );

                Koncert noviKoncert = new Koncert
                {
                    Naziv = textBoxNaziv.Text.Trim(),
                    izvodjac = izvodjac,
                    lokacija = lokacija,
                    Datum = dateTimePickerDatum.Value.Date,
                    VremePocetka = vreme,
                    VremeTrajanja = (int)numericUpDownTrajanje.Value,
                    Status = status
                };

                Kontroler.Kontroler.Instance.IzmeniKoncert(koncertZaIzmenu, noviKoncert);

                MessageBox.Show("Koncert je uspešno izmenjen.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
