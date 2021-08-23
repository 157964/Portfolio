using System.ComponentModel.DataAnnotations;

namespace Ticketsystem.Models
{
    public class Progress
    {
        [Key]
        public int Id { get; set; }

        public int Order { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}
