using Domen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forme
{
    public partial class IzvođačForma : Form
    {
        public IzvođačForma()
        {
            InitializeComponent();
        }

        private void IzvodjacForma_Load(object sender, EventArgs e)
        {
            PodesiKoloneIzvodjaci();
            UcitajIzvodjace();
            OcistiTabeluZanrova();

            BeginInvoke(new Action(() =>
            {
                dgvIzvodjaci.ClearSelection();
                dgvIzvodjaci.CurrentCell = null;
                btnOsvezi.Focus();
            }));
        }

        private void PodesiKoloneIzvodjaci()
        {
            dgvIzvodjaci.AutoGenerateColumns = false;
            dgvIzvodjaci.Columns.Clear();

            dgvIzvodjaci.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                ReadOnly = true
            });

            dgvIzvodjaci.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Naziv",
                HeaderText = "Naziv",
                DataPropertyName = "Naziv",
                ReadOnly = true
            });
        }

        private void UcitajIzvodjace()
        {
            try
            {
                List<IzvodjacPrikaz> listaZaPrikaz = new List<IzvodjacPrikaz>();

                var muzicari = Kontroler.Kontroler.Instance.VratiSveMuzicare();
                foreach (var m in muzicari)
                {
                    listaZaPrikaz.Add(new IzvodjacPrikaz
                    {
                        Id = m.Id,
                        Email = m.Email,
                        Naziv = m.Ime + " " + m.Prezime,
                        OriginalniObjekat = m
                    });
                }

                var bendovi = Kontroler.Kontroler.Instance.VratiSveBendove();
                foreach (var b in bendovi)
                {
                    listaZaPrikaz.Add(new IzvodjacPrikaz
                    {
                        Id = b.Id,
                        Email = b.Email,
                        Naziv = b.Naziv,
                        OriginalniObjekat = b
                    });
                }

                dgvIzvodjaci.DataSource = null;
                dgvIzvodjaci.DataSource = listaZaPrikaz;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju izvođača: " + ex.Message);
            }
        }

        private void UcitajZanroveIzvodjaca(int izvodjacId)
        {
            try
            {
                dgvZanrovi.DataSource = null;
                dgvZanrovi.DataSource = Kontroler.Kontroler.Instance.VratiZanroveZaIzvodjaca(izvodjacId);

                if (dgvZanrovi.Columns["Id"] != null)
                    dgvZanrovi.Columns["Id"].Visible = false;

                if (dgvZanrovi.Columns["Naziv"] != null)
                    dgvZanrovi.Columns["Naziv"].HeaderText = "Naziv žanra";

                dgvZanrovi.ClearSelection();
                dgvZanrovi.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju žanrova izvođača: " + ex.Message);
            }
        }

        private void OcistiTabeluZanrova()
        {
            dgvZanrovi.DataSource = null;
        }

        private void dgvIzvodjaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                IzvodjacPrikaz selektovan = (IzvodjacPrikaz)dgvIzvodjaci.Rows[e.RowIndex].DataBoundItem;
                UcitajZanroveIzvodjaca(selektovan.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izboru izvođača: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovde ćemo povezati modalnu formu za dodavanje.");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIzvodjaci.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite izvođača za izmenu.");
                    return;
                }

                IzvodjacPrikaz selektovanRed = (IzvodjacPrikaz)dgvIzvodjaci.CurrentRow.DataBoundItem;
                Izvodjac selektovan = selektovanRed.OriginalniObjekat;

                MessageBox.Show($"Ovde ćemo povezati modalnu formu za izmenu izvođača '{selektovanRed.Naziv}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izboru izvođača za izmenu: " + ex.Message);
            }
        }

        private void dgvIzvodjaci_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvIzvodjaci.ClearSelection();
            dgvIzvodjaci.CurrentCell = null;
            btnOsvezi.Focus();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvIzvodjaci.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite izvođača za brisanje.");
                    return;
                }

                IzvodjacPrikaz selektovanRed = (IzvodjacPrikaz)dgvIzvodjaci.CurrentRow.DataBoundItem;
                Izvodjac selektovan = selektovanRed.OriginalniObjekat;

                DialogResult rezultat = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete izvođača '{selektovanRed.Naziv}'?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rezultat == DialogResult.No) return;

                if (selektovan is Muzicar)
                    Kontroler.Kontroler.Instance.ObrisiMuzicara(selektovan.Id);
                else if (selektovan is Bend)
                    Kontroler.Kontroler.Instance.ObrisiBend(selektovan.Id);
                else
                    Kontroler.Kontroler.Instance.ObrisiIzvodjaca(selektovan.Id);

                MessageBox.Show("Uspešno obrisan izvođač.");

                UcitajIzvodjace();
                OcistiTabeluZanrova();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju izvođača: " + ex.Message);
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajIzvodjace();
            OcistiTabeluZanrova();
        }
    }
}