using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Docent
    {
        public Docent()
        {
            Vakken = new HashSet<Vak>();
        }

        public ICollection<Vak> Vakken { set; get; }

        public int Id { set; get; }

        public string Naam => $"{Voornaam} {Achternaam}";

        [StringLength(20)]
        public string Voornaam { set; get; }

        [StringLength(40)]
        public string Achternaam { set; get; }

        [ForeignKey("Locatie"), Display(Name ="Locatie")]
        public int LocatieId { set; get; }

        public virtual Locatie Locatie { set; get; }
    }
}
