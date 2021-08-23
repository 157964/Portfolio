using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticketsystem.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [ForeignKey("MainteinerId")]
        public int MaintainerId { get; set; }
        public ApplicationUser Maintainer { get; set; }
    }
}
