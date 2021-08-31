using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int SupplierID { set; get; }

        public string CompanyName { set; get; }

        public string ContactName { set; get; }

        public string Address { set; get; }

        public string Country { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}