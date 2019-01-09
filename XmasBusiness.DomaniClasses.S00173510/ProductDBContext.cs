using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasBusiness.DomaniClasses.S00173510
{
    class ProductDBContext: DbContext
    {
        public ProductDBContext() : base("SupplierConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

    }
}
