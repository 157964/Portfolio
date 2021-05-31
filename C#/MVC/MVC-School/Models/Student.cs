using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_School.Models
{
    public class Student
    {
        public Student()
        {
            StudentVakken = new HashSet<VakStudent>();
        }

        public ICollection<VakStudent> StudentVakken { set; get; }

        public int Id { set; get; }

        [StringLength(20)]
        public string Voornaam { set; get; }

        [StringLength(40)]
        public string Achternaam { set; get; }

        [StringLength(40)]
        public string Adres { set; get; }

        [StringLength(40)]
        public string Woonplaats { set; get; }

        public string Naam => $"{Voornaam} {Achternaam}";
    }
}
