using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Lokacija
    {
        public Grad grad { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public int Kapacitet { get; set; }

        public override string? ToString()
        {
            return $"{grad.ToString()} {Naziv}, {Adresa}, {Kapacitet}";
        }
    }
}
