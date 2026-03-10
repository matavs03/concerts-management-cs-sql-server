using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Forme
{
    public partial class IzvođačDetaljiForma : Form
    {
        private readonly TipIzvodjaca tipIzvodjaca;
        private readonly RezimForme rezim;
        private readonly Izvodjac izvodjacZaIzmenu;

        public IzvođačDetaljiForma(TipIzvodjaca tipIzvodjaca)
        {
            InitializeComponent();
            this.tipIzvodjaca = tipIzvodjaca;
            rezim = RezimForme.Dodavanje;
        }

        public IzvođačDetaljiForma(TipIzvodjaca tipIzvodjaca, Izvodjac izvodjac)
        {
            InitializeComponent();
            this.tipIzvodjaca = tipIzvodjaca;
            rezim = RezimForme.Izmena;
            izvodjacZaIzmenu = izvodjac;
        }

        private void IzvodjacDetaljiForma_Load(object sender, EventArgs e)
        {
            PodesiFormuPoTipu();
            UcitajZanrove();

            if (rezim == RezimForme.Izmena)
            {
                PopuniPoljaZaIzmenu();
            }
        }

        private void PodesiFormuPoTipu()
        {
            if (tipIzvodjaca == TipIzvodjaca.Muzicar)
            {
                Text = rezim == RezimForme.Dodavanje ? "Dodavanje muzičara" : "Izmena muzičara";
                lblNaslov.Text = rezim == RezimForme.Dodavanje
                    ? "Unos podataka za muzičara"
                    : "Izmena podataka za muzičara";

                lblIme.Visible = true;
                txtIme.Visible = true;

                lblPrezime.Visible = true;
                txtPrezime.Visible = true;

                lblPol.Visible = true;
                cmbPol.Visible = true;

                lblNaziv.Visible = false;
                txtNaziv.Visible = false;

                lblBrojClanova.Visible = false;
                numBrojClanova.Visible = false;

                cmbPol.Items.Clear();
                cmbPol.Items.Add(Pol.M);
                cmbPol.Items.Add(Pol.Ž);
            }
            else
            {
                Text = rezim == RezimForme.Dodavanje ? "Dodavanje benda" : "Izmena benda";
                lblNaslov.Text = rezim == RezimForme.Dodavanje
                    ? "Unos podataka za bend"
                    : "Izmena podataka za bend";

                lblIme.Visible = false;
                txtIme.Visible = false;

                lblPrezime.Visible = false;
                txtPrezime.Visible = false;

                lblPol.Visible = false;
                cmbPol.Visible = false;

                lblNaziv.Visible = true;
                txtNaziv.Visible = true;

                lblBrojClanova.Visible = true;
                numBrojClanova.Visible = true;

                numBrojClanova.Minimum = 1;
                numBrojClanova.Maximum = 100;
            }
        }

        private void UcitajZanrove()
        {
            try
            {
                clbZanrovi.Items.Clear();

                List<Zanr> sviZanrovi = Kontroler.Kontroler.Instance.VratiSveZanrove();

                foreach (Zanr zanr in sviZanrovi)
                {
                    clbZanrovi.Items.Add(zanr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju žanrova: " + ex.Message);
            }
        }

        private void PopuniPoljaZaIzmenu()
        {
            txtEmail.Text = izvodjacZaIzmenu.Email;

            if (izvodjacZaIzmenu is Muzicar muzicar)
            {
                txtIme.Text = muzicar.Ime;
                txtPrezime.Text = muzicar.Prezime;
                cmbPol.SelectedItem = muzicar.Pol;
            }
            else if (izvodjacZaIzmenu is Bend bend)
            {
                txtNaziv.Text = bend.Naziv;
                numBrojClanova.Value = bend.BrojČlanova;
            }

            for (int i = 0; i < clbZanrovi.Items.Count; i++)
            {
                Zanr zanrIzListe = (Zanr)clbZanrovi.Items[i];

                bool trebaCekirati = izvodjacZaIzmenu.Zanrovi.Any(z => z.Id == zanrIzListe.Id);

                if (trebaCekirati)
                {
                    clbZanrovi.SetItemChecked(i, true);
                }
            }
        }

        private List<Zanr> PreuzmiSelektovaneZanrove()
        {
            List<Zanr> selektovani = new List<Zanr>();

            foreach (var item in clbZanrovi.CheckedItems)
            {
                if (item is Zanr zanr)
                {
                    selektovani.Add(zanr);
                }
            }

            return selektovani;
        }

        private bool ValidirajUnos()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email je obavezan.");
                return false;
            }

            if (tipIzvodjaca == TipIzvodjaca.Muzicar)
            {
                if (string.IsNullOrWhiteSpace(txtIme.Text))
                {
                    MessageBox.Show("Ime je obavezno.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtPrezime.Text))
                {
                    MessageBox.Show("Prezime je obavezno.");
                    return false;
                }

                if (cmbPol.SelectedItem == null)
                {
                    MessageBox.Show("Pol je obavezan.");
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Naziv benda je obavezan.");
                    return false;
                }

                if (numBrojClanova.Value < 1)
                {
                    MessageBox.Show("Broj članova mora biti veći od 0.");
                    return false;
                }
            }

            return true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidirajUnos()) return;

                if (rezim == RezimForme.Dodavanje)
                {
                    SacuvajNovi();
                }
                else
                {
                    IzmeniPostojeci();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju izvođača: " + ex.Message);
            }
        }

        private void SacuvajNovi()
        {
            if (tipIzvodjaca == TipIzvodjaca.Muzicar)
            {
                Muzicar muzicar = new Muzicar
                {
                    Email = txtEmail.Text.Trim(),
                    Ime = txtIme.Text.Trim(),
                    Prezime = txtPrezime.Text.Trim(),
                    Pol = (Pol)cmbPol.SelectedItem,
                    Zanrovi = PreuzmiSelektovaneZanrove()
                };

                int noviId = Kontroler.Kontroler.Instance.SacuvajMuzicara(muzicar);

                foreach (Zanr zanr in muzicar.Zanrovi)
                {
                    Kontroler.Kontroler.Instance.SacuvajIzvodjacZanr(noviId, zanr.Id);
                }

                MessageBox.Show("Muzičar je uspešno sačuvan.");
            }
            else
            {
                Bend bend = new Bend
                {
                    Email = txtEmail.Text.Trim(),
                    Naziv = txtNaziv.Text.Trim(),
                    BrojČlanova = (int)numBrojClanova.Value,
                    Zanrovi = PreuzmiSelektovaneZanrove()
                };

                int noviId = Kontroler.Kontroler.Instance.SacuvajBend(bend);

                foreach (Zanr zanr in bend.Zanrovi)
                {
                    Kontroler.Kontroler.Instance.SacuvajIzvodjacZanr(noviId, zanr.Id);
                }

                MessageBox.Show("Bend je uspešno sačuvan.");
            }
        }

        private void IzmeniPostojeci()
        {
            if (tipIzvodjaca == TipIzvodjaca.Muzicar)
            {
                Muzicar muzicar = new Muzicar
                {
                    Id = izvodjacZaIzmenu.Id,
                    Email = txtEmail.Text.Trim(),
                    Ime = txtIme.Text.Trim(),
                    Prezime = txtPrezime.Text.Trim(),
                    Pol = (Pol)cmbPol.SelectedItem,
                    Zanrovi = PreuzmiSelektovaneZanrove()
                };

                Kontroler.Kontroler.Instance.IzmeniMuzicara(muzicar);

                Kontroler.Kontroler.Instance.ObrisiSveZanroveZaIzvodjaca(muzicar.Id);

                foreach (Zanr zanr in muzicar.Zanrovi)
                {
                    Kontroler.Kontroler.Instance.SacuvajIzvodjacZanr(muzicar.Id, zanr.Id);
                }

                MessageBox.Show("Muzičar je uspešno izmenjen.");
            }
            else
            {
                Bend bend = new Bend
                {
                    Id = izvodjacZaIzmenu.Id,
                    Email = txtEmail.Text.Trim(),
                    Naziv = txtNaziv.Text.Trim(),
                    BrojČlanova = (int)numBrojClanova.Value,
                    Zanrovi = PreuzmiSelektovaneZanrove()
                };

                Kontroler.Kontroler.Instance.IzmeniBend(bend);

                Kontroler.Kontroler.Instance.ObrisiSveZanroveZaIzvodjaca(bend.Id);

                foreach (Zanr zanr in bend.Zanrovi)
                {
                    Kontroler.Kontroler.Instance.SacuvajIzvodjacZanr(bend.Id, zanr.Id);
                }

                MessageBox.Show("Bend je uspešno izmenjen.");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}