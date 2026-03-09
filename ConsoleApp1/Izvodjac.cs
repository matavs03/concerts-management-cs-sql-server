using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Izvodjac
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public List<Zanr> Zanrovi { get; set; } = new List<Zanr>();

        public override string? ToString()
        {
            if (this is Bend bend)
                return $"Bend {bend.Naziv}";

            if (this is Muzicar muzicar)
                return $"{muzicar.Ime} {muzicar.Prezime}";

            return Email;
        }

        public virtual string PrikazNaziv => "";
    }
}
