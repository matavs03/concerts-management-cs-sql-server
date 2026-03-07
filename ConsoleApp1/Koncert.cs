using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Koncert
    {
        public Lokacija lokacija { get; set; }

        public Status Status { get; set; }

        public string Naziv { get; set; }

        public int VremeTrajanja { get; set; }

        public DateTime VremePocetka { get; set; }

        public DateTime Datum { get; set; }

        public Izvodjac izvodjac { get; set; }



        public override string? ToString()
        {
            return $"{lokacija.ToString()}, {izvodjac.ToString}, {Status}, {Naziv}, {VremeTrajanja}, {VremePocetka}, {Datum}";
        }
    }
}
