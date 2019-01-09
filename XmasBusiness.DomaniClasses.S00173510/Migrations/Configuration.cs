namespace XmasBusiness.DomaniClasses.S00173510.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<XmasBusiness.DomaniClasses.S00173510.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(XmasBusiness.DomaniClasses.S00173510.ProductDBContext context)
        {
            //SeedSupplier(context);
            SeedCategoryProducts(context);
           // NinjaProducts(context);
        }

        private void NinjaProducts(ProductDBContext context)
        {

            /* context.Products.AddOrUpdate(x => x.Description, new Product[]
                {


                     new Product()
                     {
                         Description = "Wah",
                         QuantityInStock = 500,
                         UnitPrice = 200.00f,
                         CategoryId = 1,
                         SupplierId = 3
                     }
                 });*/
            // context.SaveChanges();


            /**/

            context.Categories.AddOrUpdate(c => c.Description,
              new Category[]
              {
                    new Category
                    {
                         Description = "Bikes",
                          productsInCategory = new Product[]
                          {
                              new Product { Description = "bac",
                                              QuantityInStock = 500,
                                                 UnitPrice = 500f,
                                                 SupplierId=3,
                                                 ProductId=1

                              }
}
                    }// end-Category1

              });

            context.SaveChanges();
            /*

             */

            /*
            context.Products.AddOrUpdate(new Product[]
           {
            new Product
            {
                Description = "RT Crankarm",
                SupplierId = 3,
                CategoryId = 1,
                QuantityInStock = 500,
                UnitPrice = (float)200.00
            },
            });
            context.SaveChanges();
            */




        }


            private void SeedCategoryProducts(ProductDBContext context)
        {
            context.Categories.AddOrUpdate(c => c.Description,
                new Category[]
                {
                    new Category
                    {
                         Description = "Bikes",
                          productsInCategory = new Product[]
                          {
                              new Product {     ProductId=6,
                                                Description = "LL Crankarm",
                                                 QuantityInStock = 500,
                                                 UnitPrice = 500f,
                                                 SupplierId=3
                                                 
                              },
                               new Product { ProductId=7,
                                        Description = "ML Crankarm",
                                              QuantityInStock = 500,
                                                 UnitPrice = 200f,
                                                 SupplierId=3
                                                

                              }
                          }
                    },// end-Category1

                    new Category
                    {
                         Description = "Components",
                          productsInCategory = new Product[]
                          {
                              new Product { ProductId=1,
                                  Description = "Adjustable Race",
                                              QuantityInStock = 1000,
                                                 UnitPrice = 100f,
                                                 SupplierId=1
                                                 
                              },
                               new Product {    ProductId=2,
                                   Description = "Bearing Ball",
                                              QuantityInStock = 1000,
                                                 UnitPrice = 1f,
                                                 SupplierId=2
                                                 

                              },
                              new Product { ProductId=3,
                                  Description = "BB Ball Bearing",
                                              QuantityInStock = 800,
                                                 UnitPrice = 2f,
                                                 SupplierId=2
                              },
                               new Product { ProductId=4,
                                   Description = "Headset Ball Bearing",
                                              QuantityInStock = 800,
                                                 UnitPrice = 10f,
                                                 SupplierId=1
                              },
                          }
                    },// end-Category2
                    new Category
                    {
                         Description = "Clothing",
                          productsInCategory = new Product[]
                          {

                          }
                    },// end-Category3
                    new Category
                    {
                         Description = "Components",
                          productsInCategory = new Product[]
                          {
                              new Product { ProductId=5,                                  Description = "Blade",
                                              QuantityInStock = 800,
                                                 UnitPrice = 25.5f,
                                                 SupplierId=1
                              }
                          }
                    }// end-Category4






                }
                );
            context.SaveChanges();
        }
        private void SeedSupplier(ProductDBContext context)
        {
            context.Supplier.AddOrUpdate(s => s.SupplierName,



                new Supplier[] {
                    new Supplier {
                                    SupplierName="Supplier 1",
                                    Address="Address for Supplier 1"
                                 },
                     new Supplier {
                                    SupplierName="Supplier 2",
                                    Address="Address for Supplier 2"
                                 },
                      new Supplier {
                                    SupplierName="Supplier 3",
                                    Address="Address for Supplier 3"
                                 }
                                });
            context.SaveChanges();
        }
    }
}
