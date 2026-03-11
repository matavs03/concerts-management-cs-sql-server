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
    public partial class LokacijaForma : Form
    {
        public LokacijaForma()
        {
            InitializeComponent();
        }

        private void LokacijaForma_Load(object sender, EventArgs e)
        {
            PodesiKoloneLokacija();
            UcitajLokacije();

            BeginInvoke(new Action(() =>
            {
                dgvLokacije.ClearSelection();
                dgvLokacije.CurrentCell = null;
                btnOsvezi.Focus();
            }));
        }

        private void PodesiKoloneLokacija()
        {
            dgvLokacije.AutoGenerateColumns = false;
            dgvLokacije.Columns.Clear();

            dgvLokacije.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id", // veza sa property-jem iz LokacijaPrikaz
                ReadOnly = true,
                Width = 50 // opciono manja širina
            });

            dgvLokacije.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Naziv",
                HeaderText = "Naziv",
                DataPropertyName = "Naziv",
                ReadOnly = true
            });

            dgvLokacije.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Adresa",
                HeaderText = "Adresa",
                DataPropertyName = "Adresa",
                ReadOnly = true
            });

            dgvLokacije.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Kapacitet",
                HeaderText = "Kapacitet",
                DataPropertyName = "Kapacitet",
                ReadOnly = true
            });

            dgvLokacije.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Grad",
                HeaderText = "Grad",
                DataPropertyName = "NazivGrada",
                ReadOnly = true
            });
        }

        private void UcitajLokacije()
        {
            try
            {
                List<LokacijaPrikaz> listaZaPrikaz = new List<LokacijaPrikaz>();
                var lokacije = Kontroler.Kontroler.Instance.VratiSveLokacije();

                foreach (var l in lokacije)
                {
                    listaZaPrikaz.Add(new LokacijaPrikaz
                    {
                        Id = l.id,
                        Naziv = l.Naziv,
                        Adresa = l.Adresa,
                        Kapacitet = l.Kapacitet,
                        NazivGrada = l.grad?.Naziv,
                        OriginalniObjekat = l
                    });
                }

                dgvLokacije.DataSource = null;
                dgvLokacije.DataSource = listaZaPrikaz;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lokacija: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                using (LokacijaDetaljiForma forma = new LokacijaDetaljiForma())
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                        UcitajLokacije();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju lokacije: " + ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLokacije.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite lokaciju za izmenu.");
                    return;
                }

                LokacijaPrikaz selektovana = (LokacijaPrikaz)dgvLokacije.CurrentRow.DataBoundItem;
                Lokacija lok = selektovana.OriginalniObjekat;

                using (LokacijaDetaljiForma forma = new LokacijaDetaljiForma(lok))
                {
                    if (forma.ShowDialog() == DialogResult.OK)
                        UcitajLokacije();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni lokacije: " + ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLokacije.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite lokaciju za brisanje.");
                    return;
                }

                LokacijaPrikaz selektovana = (LokacijaPrikaz)dgvLokacije.CurrentRow.DataBoundItem;
                DialogResult rezultat = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete lokaciju '{selektovana.Naziv}'?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rezultat == DialogResult.No) return;

                Kontroler.Kontroler.Instance.ObrisiLokaciju(selektovana.Id);
                MessageBox.Show("Uspešno obrisana lokacija.");
                UcitajLokacije();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju lokacije: " + ex.Message);
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajLokacije();
        }

        private void dgvLokacije_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLokacije.ClearSelection();
            dgvLokacije.CurrentCell = null;
            btnOsvezi.Focus();
        }


    }

    // Klasa za prikaz u DataGridView
    public class LokacijaPrikaz
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int Kapacitet { get; set; }
        public string NazivGrada { get; set; }
        public Lokacija OriginalniObjekat { get; set; }
    }
}

