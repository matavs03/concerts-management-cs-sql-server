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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
            private void btnKupi_Click(object sender, EventArgs e)
        {
            try
            {
                Karta karta = new Karta
                {
                    Koncert = selektovaniKoncert,
                    Red = (int)numericUpDown1.Value,
                    Sediste = (int)numericUpDown2.Value,
                  //  Cena = IzracunajCenu(numericUpDown1.Value)
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

        private decimal IzracunajCenu(int Red)
        {
            if (Red <= 5)
                return 4000;

            if (Red <= 10)
                return 3000;

            return 2000;
        }
    }
}
