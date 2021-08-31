using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryID { set; get; }

        [Required]
        public string CategoryName { set; get; }

        public string Description { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
