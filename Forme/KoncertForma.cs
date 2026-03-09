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
using Kontroler;

namespace Forme
{
    public partial class KoncertForma : Form
    {
        public KoncertForma()
        {
            InitializeComponent();
        }

        private void KoncertForma_Load(object sender, EventArgs e)
        {
            UcitajKoncerte();
        }

        private void UcitajKoncerte()
        {
            List<Koncert> koncerti = Kontroler.Kontroler.Instance.VratiSveKoncerte();

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = koncerti;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["VremePocetka"].DefaultCellStyle.Format = @"hh\:mm";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Naziv"].DisplayIndex = 0;
            dataGridView1.Columns["izvodjac"].DisplayIndex = 1;
            dataGridView1.Columns["Datum"].DisplayIndex = 2;
            dataGridView1.Columns["lokacija"].DisplayIndex = 3;
            dataGridView1.Columns["Status"].DisplayIndex = 4;
            dataGridView1.Columns["VremePocetka"].DisplayIndex = 5;
            dataGridView1.Columns["VremeTrajanja"].DisplayIndex = 6;

            dataGridView1.Columns["Naziv"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["izvodjac"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["lokacija"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["VremeTrajanja"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Datum"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["VremePocetka"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns["izvodjac"].HeaderText = "Izvođač";
            dataGridView1.Columns["lokacija"].HeaderText = "Lokacija";


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Morate izabrati koncert.");
                return;
            }

            Koncert izabraniKoncert = (Koncert)dataGridView1.CurrentRow.DataBoundItem;

            if (izabraniKoncert.Status == Status.Otkazan || izabraniKoncert.Status == Status.Održan || izabraniKoncert.Status == Status.Rasprodat)
            {
                MessageBox.Show("Za ovaj koncert nije moguće kupiti kartu.");
                return;
            }
            KartaForm forma = new KartaForm(izabraniKoncert);
            forma.ShowDialog();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Izaberite koncert koji želite da obrišete.");
                return;
            }

            Koncert selektovaniKoncert = (Koncert)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult rezultat = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete selektovani koncert?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    Kontroler.Kontroler.Instance.ObrisiKoncert(
                        selektovaniKoncert.izvodjac.Id,
                        selektovaniKoncert.lokacija.LokacijaId,
                        selektovaniKoncert.Datum
                    );

                    MessageBox.Show("Koncert je uspešno obrisan.");
                    UcitajKoncerte();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajIzmeniKoncertForma forma = new DodajIzmeniKoncertForma();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajKoncerte();
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Izaberite koncert.");
                return;
            }

            Koncert selektovaniKoncert = (Koncert)dataGridView1.CurrentRow.DataBoundItem;

            DodajIzmeniKoncertForma forma = new DodajIzmeniKoncertForma(selektovaniKoncert);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajKoncerte();
            }
        }
    }
}
