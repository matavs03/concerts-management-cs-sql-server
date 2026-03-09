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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forme
{
    public partial class KartaForm : Form
    {
        private Koncert selektovaniKoncert;

        public KartaForm(Koncert koncert)
        {
            InitializeComponent();
            selektovaniKoncert = koncert;

        }

        private void KartaForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Kupovina karata za koncert: {selektovaniKoncert.Naziv}";
            OsveziCenu();
        }

       


        private void btnKupi_Click(object sender, EventArgs e)
        {
            try
            {
                Karta karta = new Karta
                {
                    Koncert = selektovaniKoncert,
                    Red = (int)numericUpDownRed.Value,
                    Sediste = (int)numericUpDownSediste.Value,
                };

                Kontroler.Kontroler.Instance.SacuvajKartu(karta);

                MessageBox.Show("Karta je uspešno kupljena.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private decimal IzracunajCenu(int red)
        {
            if (red >= 1 && red <= 20)
                return 4500;

            if (red >= 21 && red <= 50)
                return 3000;

            return 1800;
        }

        private void OsveziCenu()
        {
            int red = (int)numericUpDownRed.Value;
            decimal cena = IzracunajCenu(red);
            txtCena.Text = cena.ToString();
        }

       

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            OsveziCenu();
        }
    }
}
