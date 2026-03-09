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
    public partial class GradForma : Form
    {
        public GradForma()
        {
            InitializeComponent();
        }

        private void GradForma_Load(object sender, EventArgs e)
        {
            UcitajGradove();
        }

        private void UcitajGradove()
        {
            try
            {
                dgvZanrovi.DataSource = null;
                dgvZanrovi.DataSource = Kontroler.Kontroler.Instance.VratiSveGradove();

                if (dgvZanrovi.Columns["Id"] != null)
                    dgvZanrovi.Columns["Id"].Visible = false;

                if (dgvZanrovi.Columns["Naziv"] != null)
                    dgvZanrovi.Columns["Naziv"].HeaderText = "Naziv grada";

                dgvZanrovi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju gradova: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv grada.");
                    return;
                }

                Grad g = new Grad
                {
                    Naziv = txtNaziv.Text.Trim()
                };

                Kontroler.Kontroler.Instance.SacuvajGrad(g);
                MessageBox.Show("Uspešno dodat grad.");

                txtNaziv.Clear();
                UcitajGradove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju grada: " + ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZanrovi.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite grad za izmenu.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv grada.");
                    return;
                }

                Grad selektovan = (Grad)dgvZanrovi.CurrentRow.DataBoundItem;
                selektovan.Naziv = txtNaziv.Text.Trim();

                Kontroler.Kontroler.Instance.IzmeniGrad(selektovan);
                MessageBox.Show("Uspešno izmenjen grad.");

                txtNaziv.Clear();
                UcitajGradove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni grada: " + ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZanrovi.CurrentRow == null)
                {
                    MessageBox.Show("Izaberite grad za brisanje.");
                    return;
                }

                Grad selektovan = (Grad)dgvZanrovi.CurrentRow.DataBoundItem;

                DialogResult rezultat = MessageBox.Show(
                    $"Da li ste sigurni da želite da obrišete grad '{selektovan.Naziv}'?",
                    "Potvrda brisanja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rezultat == DialogResult.No) return;

                Kontroler.Kontroler.Instance.ObrisiGrad(selektovan.Id);
                MessageBox.Show("Uspešno obrisan grad.");

                txtNaziv.Clear();
                UcitajGradove();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju grada: " + ex.Message);
            }
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            UcitajGradove();
        }

        private void dgvZanrovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                Grad selektovan = (Grad)dgvZanrovi.Rows[e.RowIndex].DataBoundItem;
                txtNaziv.Text = selektovan.Naziv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izboru grada: " + ex.Message);
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            // Možeš dodati logiku validacije dok korisnik unosi tekst
        }

    }
}
