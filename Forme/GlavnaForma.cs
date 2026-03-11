namespace Forme
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void žanrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ŽanrForma forma = new ŽanrForma();
            forma.ShowDialog();
        }

        private void izvođačToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvođačForma forma = new IzvođačForma();
            forma.ShowDialog();
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradForma forma = new GradForma();
            forma.ShowDialog();

        }
        private void koncertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KoncertForma forma = new KoncertForma();
            forma.ShowDialog();
        }

        private void lokacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LokacijaForma forma = new LokacijaForma();
            forma.ShowDialog();
        }
    }
}
