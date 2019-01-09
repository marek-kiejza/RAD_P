using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasBusiness.DomaniClasses.S00173510
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Quantity in Stock")]
        public int QuantityInStock { get; set; }

        [Display(Name = "Unit Price")]
        public float UnitPrice { get; set; }

        [ForeignKey("associatedSupplier")]
        public int SupplierId { get; set; }

        [ForeignKey("associatedCategory")]
        public int CategoryId { get; set; }



        //Foren Key of Caregory
        public virtual Category associatedCategory { get; set; }
        public virtual Supplier associatedSupplier { get; set; }
    }
}
