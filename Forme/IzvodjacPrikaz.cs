using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    internal class IzvodjacPrikaz
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Naziv { get; set; }
        public Izvodjac OriginalniObjekat { get; set; }
    }
}
