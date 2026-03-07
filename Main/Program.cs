using Forme;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlavnaForma());
        }
    }
}
