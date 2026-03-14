using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class LokacijaDetaljiForma : Form
    {
        private readonly RezimForme rezim;
        private readonly Lokacija lokacijaZaIzmenu;

        public LokacijaDetaljiForma()
        {
            InitializeComponent();
            rezim = RezimForme.Dodavanje;
        }

        public LokacijaDetaljiForma(Lokacija lokacija)
        {
            InitializeComponent();
            rezim = RezimForme.Izmena;
            lokacijaZaIzmenu = lokacija;
        }

        private void LokacijaDetaljiForma_Load(object sender, EventArgs e)
        {
            UcitajGradove();

            if (rezim == RezimForme.Izmena)
            {
                PopuniPoljaZaIzmenu();
            }
        }

        private void UcitajGradove()
        {
            try
            {
                cmbGrad.DataSource = Kontroler.Kontroler.Instance.VratiSveGradove();
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju gradova: " + ex.Message);
            }
        }

        private void PopuniPoljaZaIzmenu()
        {
            txtNaziv.Text = lokacijaZaIzmenu.Naziv;
            txtAdresa.Text = lokacijaZaIzmenu.Adresa;
            numKapacitet.Value = lokacijaZaIzmenu.Kapacitet;

            cmbGrad.SelectedItem = ((List<Grad>)cmbGrad.DataSource)
                                  .FirstOrDefault(g => g.Id == lokacijaZaIzmenu.grad.Id);
        }

        private bool ValidirajUnos()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Naziv lokacije je obavezan.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Adresa lokacije je obavezna.");
                return false;
            }

            if (numKapacitet.Value < 1)
            {
                MessageBox.Show("Kapacitet mora biti veći od 0.");
                return false;
            }

            if (cmbGrad.SelectedItem == null)
            {
                MessageBox.Show("Grad mora biti izabran.");
                return false;
            }

            return true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidirajUnos()) return;

                string naziv = txtNaziv.Text.Trim();
                string adresa = txtAdresa.Text.Trim();

                Regex nazivRegex = new Regex(@"^[A-Z][a-zA-Z]*(?: [a-zA-Z]+)*$");
                Regex adresaRegex = new Regex(@"^[A-Z][a-z]+(?:\s[A-Z]?[a-z]+)*\s[0-9]+(?:/[0-9]+)?$");

                if (!nazivRegex.IsMatch(naziv))
                {
                    MessageBox.Show("Naziv mora početi velikim slovom");
                    return;
                }

                if (!adresaRegex.IsMatch(adresa))
                {
                    MessageBox.Show("Adresa mora početi velikim slovom, sadržati naziv ulice i broj");
                    return;
                }

                Grad izabraniGrad = (Grad)cmbGrad.SelectedItem;

                if (rezim == RezimForme.Dodavanje)
                {
                    Lokacija novaLokacija = new Lokacija
                    {
                        Naziv = naziv,
                        Adresa = adresa,
                        Kapacitet = (int)numKapacitet.Value,
                        grad = izabraniGrad
                    };

                    Kontroler.Kontroler.Instance.SacuvajLokaciju(novaLokacija);
                    MessageBox.Show("Lokacija je uspešno sačuvana.");
                }
                else
                {
                    lokacijaZaIzmenu.Naziv = naziv;
                    lokacijaZaIzmenu.Adresa = adresa;
                    lokacijaZaIzmenu.Kapacitet = (int)numKapacitet.Value;
                    lokacijaZaIzmenu.grad = izabraniGrad;

                    Kontroler.Kontroler.Instance.IzmeniLokaciju(lokacijaZaIzmenu);
                    MessageBox.Show("Lokacija je uspešno izmenjena.");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju lokacije: " + ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

