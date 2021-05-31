using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_School.Models
{
    public class Locatie
    {
        public Locatie()
        {
            Docenten = new HashSet<Docent>();
        }

        public ICollection<Docent> Docenten { set; get; }

        public int Id { set; get; }

        [StringLength(20)]
        public string Naam { set; get; }

        [StringLength(40)]
        public string Adres { set; get; }

        [StringLength(40)]
        public string Woonplaats { set; get; }
    }
}
