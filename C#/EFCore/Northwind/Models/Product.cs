using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    public class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int ProductID { set; get; }

        [Required, StringLength(40)]
        public string ProductName { set; get; }

        public short UnitsOnOrder { set; get; }

        [ForeignKey("SupplierID")]
        public int SupplierID { set; get; }

        public virtual Supplier Supplier { set; get; }

        [ForeignKey("CategoryID")]
        public int CategoryID { set; get; }

        public virtual Category Category { set; get; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitPrice { set; get; }

    }
}