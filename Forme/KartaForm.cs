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
            label1.Text = selektovaniKoncert.Naziv;
        }

       
    }
}
