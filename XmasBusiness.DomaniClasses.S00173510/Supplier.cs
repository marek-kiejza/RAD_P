using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasBusiness.DomaniClasses.S00173510
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "SupplierID")]
        public int SupplierId { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        public virtual ICollection<Product> productsInSupplier { get; set; }
    }
}
