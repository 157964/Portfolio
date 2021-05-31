using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    public class Vak
    {
        public Vak()
        {
            VakStudenten = new HashSet<VakStudent>();
        }

        public ICollection<VakStudent> VakStudenten { set; get; }

        [Key]
        public int Id { set; get; }

        [StringLength(20)]
        public string Naam { set; get; }

        [ForeignKey("Docent")]
        public int DocentId { set; get; }

        public virtual Docent Docent { set; get; }
    }
}
