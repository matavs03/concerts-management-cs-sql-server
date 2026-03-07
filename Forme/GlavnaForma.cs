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
    }
}
