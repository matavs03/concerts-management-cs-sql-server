using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Karta
    {

        public Lokacija lokacija { get; set; }
        public int Cena { get; set; }

        public int Sediste { get; set; }

        public int Red { get; set; }

        public DateTime Datum { get; set; }

        public Izvodjac izvodjac { get; set; }
        public Koncert Koncert { get; set; }


        public override string? ToString()
        {
            return $"{lokacija.ToString()}, {izvodjac.ToString}, cena: {Cena}, sediste: {Sediste}, red: {Red}, {Datum}";
        }
    }
}
