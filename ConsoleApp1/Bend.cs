using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Bend : Izvodjac
    {
        public string Naziv { get; set; }
        public int BrojČlanova { get; set; }

        public override string PrikazNaziv => Naziv;
    }
}
