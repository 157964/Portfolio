using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    public class Medewerker : Persoon
    {
        public string Rol { set; get; }
        /*
        public Medewerker(string rol)
        {
            Rol = rol;

        }
        */
        public override string WieBenIk()
        {
            return $"Mijn naam is {Voornaam}, mijn achternaam is {Achternaam} en mijn rol is {Rol}";
        }
    }

    public class Manager : Medewerker
    {
        public string Afdeling { set; get; } = "Bijzaken";

        public override string WieBenIk()
        {
            return $"Mijn naam is {Voornaam} {Achternaam} en mijn afdeling is {Afdeling}";
        }

    }
}
