using Domen;
using Kontroler;
using System;
using System.Windows.Forms;

namespace Forme
{
    public partial class ŽanrForma : Form
    {
        public ŽanrForma()
        {
            InitializeComponent();
        }

        private void ŽanrForma_Load(object sender, EventArgs e)
        {
            UcitajZanrove();
        }

        private void UcitajZanrove()
        {
            try
            {
                dgvZanrovi.DataSource = null;
                dgvZanrovi.DataSource = Kontroler.Kontroler.Instance.VratiSveZanrove();

                if (dgvZanrovi.Columns["Id"] != null)
                    dgvZanrovi.Columns["Id"].Visible = false;

                if (dgvZanrovi.Columns["Naziv"] != null)
                    dgvZanrovi.Columns["Naziv"].HeaderText = "Naziv žanra";

                dgvZanrovi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju žanrova: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv žanra.");
                    return;
                }

                Zanr z = new Zanr
                {
                    Naziv = txtNaziv.Text.Trim()
                };

                Kontroler.Kontroler.Instance.SacuvajZanr(z);
                MessageBox.Show("Uspešno dodat žanr.");

                txtNaziv.Clear();
                UcitajZanrove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju žanra: " + ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZanrovi.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite žanr za izmenu.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv žanra.");
                    return;
                }

                Zanr selektovan = (Zanr)dgvZanrovi.CurrentRow.DataBoundItem;
                selektovan.Naziv = txtNaziv.Text.Trim();

                Kontroler.Kontroler.Instance.IzmeniZanr(selektovan);
                MessageBox.Show("Uspešno izmenjen žanr.");

                txtNaziv.Clear();
                UcitajZanrove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni žanra: " + ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZanrovi.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite žanr za brisanje.");
                    return;
                }

                Zanr selektovan = (Zanr)dgvZanrovi.CurrentRow.DataBoundItem;

                DialogResult rezultat = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete žanr '{selektovan.Naziv}'?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rezultat == DialogResult.No) return;

                Kontroler.Kontroler.Instance.ObrisiZanr(selektovan.Id);
                MessageBox.Show("Uspešno obrisan žanr.");

                txtNaziv.Clear();
                UcitajZanrove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju žanra: " + ex.Message);
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajZanrove();
        }

        private void dgvZanrovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                Zanr selektovan = (Zanr)dgvZanrovi.Rows[e.RowIndex].DataBoundItem;
                txtNaziv.Text = selektovan.Naziv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izboru žanra: " + ex.Message);
            }
        }
    }
}
