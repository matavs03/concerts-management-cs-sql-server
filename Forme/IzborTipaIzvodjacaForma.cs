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
    public partial class IzborTipaIzvodjacaForma : Form
    {
        public TipIzvodjaca? IzabraniTip { get; private set; }

        public IzborTipaIzvodjacaForma()
        {
            InitializeComponent();
        }

        private void btnMuzicar_Click(object sender, EventArgs e)
        {
            IzabraniTip = TipIzvodjaca.Muzicar;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBend_Click(object sender, EventArgs e)
        {
            IzabraniTip = TipIzvodjaca.Bend;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public enum TipIzvodjaca
    {
        Muzicar,
        Bend
    }
}
