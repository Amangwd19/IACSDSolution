using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class BusinessManager
    {

        public static Vendor GetVendor(int id)
        {
            // return new Product { ID = id, Title = "Gerbera", Description = "wedding Flower", UnitPrice = 6, Quantity = 5000 };
            //  return DBManager.GetByID(id);
            return DBManager.GetByIDV(id);
        }

        public static List<Vendor> GetAllVendors()
        {
            List<Vendor> allVendors = new List<Vendor>();
            allVendors = DBManager.GetAllVendors();
            return allVendors;

            /*  allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
              allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 0 });
              allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
              allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
              allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
              allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
              allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Quantity = 0 });
              allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
              allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
              allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
              allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
              allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Quantity = 10000 });

              return allProducts;
            */
        }


        public static bool InsertV(Vendor newVendor)
        {
            return DBManager.InsertV(newVendor);
        }
        public static bool UpdateV(Vendor newVendor)
        {
            return DBManager.UpdateV(newVendor);
        }

        public static Product GetProduct(int id)
        {
            // return new Product { ID = id, Title = "Gerbera", Description = "wedding Flower", UnitPrice = 6, Quantity = 5000 };
            //  return DBManager.GetByID(id);
            return DBManager.GetByID(id);
        }
        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts = DBManager.GetAllProducts();
            return allProducts;

            /*  allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
              allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 0 });
              allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
              allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
              allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
              allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
              allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Quantity = 0 });
              allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
              allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
              allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
              allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
              allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Quantity = 10000 });

              return allProducts;
            */
        }



        //day15 All files
        public static bool Insert(Product newProduct)
        {
            return DBManager.Insert(newProduct);
        }
        public static bool Update(Product newProduct)
        {
            return DBManager.Update(newProduct);
        }
        public static bool Delete(int id)
        {
            return DBManager.Delete(id);
        }

        //Analytical functionalities

        public static List<string> GetTopTenCustomers()
        {
            List<string> customers = new List<string>();
            customers.Add("Microsoft");
            customers.Add("IBM");
            customers.Add("Oracle");
            customers.Add("Google");
            customers.Add("Facebook");
            customers.Add("Infosys");
            customers.Add("Tcs");
            customers.Add("IET");
            customers.Add("IACSD");
            customers.Add("KnowIT");
            return customers;
        }
        public static List<Customer> GetTopCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Manoj", Age = 32, Location = "Nagpur", PhoneNumber = "9881735806", Email = "manoj.tambade@transflower.in" });
            customers.Add(new Customer { Id = 2, Name = "Manisha", Age = 24, Location = "Delhi", PhoneNumber = "9881735861", Email = "manisha.jadhav@transflower.in" });
            customers.Add(new Customer { Id = 3, Name = "Ravi", Age = 32, Location = "Mumbai", PhoneNumber = "9881735441", Email = "ravi.pant@transflower.in" });
            customers.Add(new Customer { Id = 4, Name = "Rajiv", Age = 25, Location = "Mumbai", PhoneNumber = "9881735856", Email = "rajiv.gore@transflower.in" });
            customers.Add(new Customer { Id = 5, Name = "Gokul", Age = 32, Location = "Kanpur", PhoneNumber = "9881735236", Email = "gokul.varma@transflower.in" });
            customers.Add(new Customer { Id = 6, Name = "sheetal", Age = 22, Location = "Nashik", PhoneNumber = "9881735765", Email = "sheetal.kulkarni@transflower.in" });
            customers.Add(new Customer { Id = 7, Name = "Amarn", Age = 32, Location = "Delhi", PhoneNumber = "9881733761", Email = "amar.sharma@transflower.in" });
            customers.Add(new Customer { Id = 8, Name = "Sarang", Age = 24, Location = "Pune", PhoneNumber = "9881735871", Email = "sarang.Agarwal@transflower.in" });

            return customers;
        }

        public static List<string> GetTopTenOrders()
        {
            List<string> orders = new List<string>();
            orders.Add("Azure Programming");
            orders.Add("DotNet 5 Application Development");
            orders.Add("Spring Boot api for Microservices");
            orders.Add("MongoDB Programming");
            orders.Add("React JS Single Page Applications");
            orders.Add("Angular SPA with WebAPI");
            orders.Add("WPF Programming");
            orders.Add("Dev Ops  Training");
            orders.Add("SQL Programming");
            orders.Add("C++ Systems Programming");
            return orders;
        }

        // methods for LINQ TryOuts

        /*   public static List<Product> GetSoldOutProducts()
           {
               //List<Product> products = GetAllProducts();
               List<Product> products = GetAllProductsFromDatabase();

               var soldOutProducts = from prod in products
                                     where prod.Quantity == 0
                                     select prod;
               return soldOutProducts as List<Product>;
           }
          */
        public static List<Product> GetProuductsInStockLessthan(int amount)
        {
            List<Product> products = DBManager.GetAllProducts();
            var expensiveInStockProducts =
                from prod in products
                where prod.Quantity > 0 && prod.UnitPrice > amount
                select prod;

            return expensiveInStockProducts as List<Product>;
        }

        public static List<string> GetProjectTitles()
        {
            List<Product> products = DBManager.GetAllProducts();

            var productNames =
                from prod in products
                select prod.Title;

            return productNames as List<string>;
        }

        public static dynamic GetProductDetails()
        {
            List<Product> products = DBManager.GetAllProducts();

            var productInfos =
                from prod in products
                select new { prod.Title, prod.Description, Price = prod.UnitPrice };

            return productInfos;


        }

        public static IEnumerable<int> Takethree()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var first3Numbers = numbers.Take(3);
            return first3Numbers;
        }

        public static IEnumerable<int> Skip()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4);
            return allButFirst4Numbers;

        }

        public static List<string> GetFruitsOrderby()
        {
            string[] words = { "cherry", "apple", "blueberry", "banana", "mango" };
            var sortedWords =
                                from word in words
                                orderby word
                                select word;
            return sortedWords as List<string>;
        }

        public static List<Product> GetProductsOrderby()
        {
            List<Product> products = DBManager.GetAllProducts();

            var sortedProducts =
                                from prod in products
                                orderby prod.Quantity
                                select prod;

            return sortedProducts as List<Product>;

        }

        public static List<Product> GetProductsByDescending()
        {
            List<Product> products = DBManager.GetAllProducts();

            var sortedProducts =
                                from prod in products
                                orderby prod.Quantity descending
                                select prod;

            return sortedProducts as List<Product>;
        }

        public static List<Product> GetProductsGroupByQuantity()
        {
            List<Product> products = DBManager.GetAllProducts();

            var orderGroups =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, Products = prodGroup };

            return orderGroups as List<Product>;
        }

        public static List<string> GetProductsDistinct()
        {
            List<Product> products = DBManager.GetAllProducts();
            var categoryNames = (from prod in products
                                 select prod.Quantity).Distinct();

            return categoryNames as List<string>;

        }

        public static void ToDictionary()
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                       new {Name = "Bob"  , Score = 40},
                                       new {Name = "Cathy", Score = 45}
                            };

            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);


        }

        public static Product GetFifthProduct()
        {
            List<Product> products = DBManager.GetAllProducts();
            Product product5 = products.FirstOrDefault(p => p.ID == 5);
            return product5;
        }

        public static dynamic GetProductCount()
        {
            List<Product> products = DBManager.GetAllProducts();

            var categoryCounts =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };

            return categoryCounts;
        }

        public static dynamic GetAveragePriceOfCategory()
        {
            List<Product> products = GetAllProducts();
            var categories =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            return categories;


        }

        public static List<Product> GetAllHardcodedProducts()
        {
            List<Product> allProducts = new List<Product>();

            allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
            allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
            allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 3400 });
            allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
            allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
            allProducts.Add(new Product { ID = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Quantity = 2000 });
            allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
            allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
            allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
            allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Quantity = 0 });
            allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
            allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
            allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
            allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
            allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Quantity = 10000 });
            return allProducts;
        }

        public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = DBManager.GetAllProducts();

            return allProducts;
        }




        //2nd copy
      /*  public static Product GetProduct(int id)
        {
            // return new Product { ID = id, Title = "Gerbera", Description = "wedding Flower", UnitPrice = 6, Quantity = 5000 };
            //  return DBManager.GetByID(id);
            return DBManager.GetByID(id);
        }
      */
     /*   public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts = DBManager.GetAllProducts();
            return allProducts;

              allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
              allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 0 });
              allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
              allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
              allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
              allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
              allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
              allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Quantity = 0 });
              allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
              allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
              allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
              allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
              allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Quantity = 10000 });

              return allProducts;
            */
        }



        //day15 All files
      /*  public static bool Insert(Product newProduct)
        {
            return DBManager.Insert(newProduct);
        }
      */
       /* public static bool Update(Product newProduct)
        {
            return DBManager.Update(newProduct);
        }
       */
       /* public static bool Delete(int id)
        {
            return DBManager.Delete(id);
        }
       */
        //Analytical functionalities

     /*   public static List<string> GetTopTenCustomers()
        {
            List<string> customers = new List<string>();
            customers.Add("Microsoft");
            customers.Add("IBM");
            customers.Add("Oracle");
            customers.Add("Google");
            customers.Add("Facebook");
            customers.Add("Infosys");
            customers.Add("Tcs");
            customers.Add("IET");
            customers.Add("IACSD");
            customers.Add("KnowIT");
            return customers;
        }
     */
     /*   public static List<Customer> GetTopCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Manoj", Age = 32, Location = "Nagpur", PhoneNumber = "9881735806", Email = "manoj.tambade@transflower.in" });
            customers.Add(new Customer { Id = 2, Name = "Manisha", Age = 24, Location = "Delhi", PhoneNumber = "9881735861", Email = "manisha.jadhav@transflower.in" });
            customers.Add(new Customer { Id = 3, Name = "Ravi", Age = 32, Location = "Mumbai", PhoneNumber = "9881735441", Email = "ravi.pant@transflower.in" });
            customers.Add(new Customer { Id = 4, Name = "Rajiv", Age = 25, Location = "Mumbai", PhoneNumber = "9881735856", Email = "rajiv.gore@transflower.in" });
            customers.Add(new Customer { Id = 5, Name = "Gokul", Age = 32, Location = "Kanpur", PhoneNumber = "9881735236", Email = "gokul.varma@transflower.in" });
            customers.Add(new Customer { Id = 6, Name = "sheetal", Age = 22, Location = "Nashik", PhoneNumber = "9881735765", Email = "sheetal.kulkarni@transflower.in" });
            customers.Add(new Customer { Id = 7, Name = "Amarn", Age = 32, Location = "Delhi", PhoneNumber = "9881733761", Email = "amar.sharma@transflower.in" });
            customers.Add(new Customer { Id = 8, Name = "Sarang", Age = 24, Location = "Pune", PhoneNumber = "9881735871", Email = "sarang.Agarwal@transflower.in" });

            return customers;
        }
     */

     /*   public static List<string> GetTopTenOrders()
        {
            List<string> orders = new List<string>();
            orders.Add("Azure Programming");
            orders.Add("DotNet 5 Application Development");
            orders.Add("Spring Boot api for Microservices");
            orders.Add("MongoDB Programming");
            orders.Add("React JS Single Page Applications");
            orders.Add("Angular SPA with WebAPI");
            orders.Add("WPF Programming");
            orders.Add("Dev Ops  Training");
            orders.Add("SQL Programming");
            orders.Add("C++ Systems Programming");
            return orders;
        }

    */
        // methods for LINQ TryOuts

        /*   public static List<Product> GetSoldOutProducts()
           {
               //List<Product> products = GetAllProducts();
               List<Product> products = GetAllProductsFromDatabase();

               var soldOutProducts = from prod in products
                                     where prod.Quantity == 0
                                     select prod;
               return soldOutProducts as List<Product>;
           }
          */
      /*  public static List<Product> GetProuductsInStockLessthan(int amount)
        {
            List<Product> products = DBManager.GetAllProducts();
            var expensiveInStockProducts =
                from prod in products
                where prod.Quantity > 0 && prod.UnitPrice > amount
                select prod;

            return expensiveInStockProducts as List<Product>;
        }
      */

    /*    public static List<string> GetProjectTitles()
        {
            List<Product> products = DBManager.GetAllProducts();

            var productNames =
                from prod in products
                select prod.Title;

            return productNames as List<string>;
        }
    */
     /*   public static dynamic GetProductDetails()
        {
            List<Product> products = DBManager.GetAllProducts();

            var productInfos =
                from prod in products
                select new { prod.Title, prod.Description, Price = prod.UnitPrice };

            return productInfos;


        }
     */
     /* public static IEnumerable<int> Takethree()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var first3Numbers = numbers.Take(3);
            return first3Numbers;
        }

        public static IEnumerable<int> Skip()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4);
            return allButFirst4Numbers;

        }

        public static List<string> GetFruitsOrderby()
        {
            string[] words = { "cherry", "apple", "blueberry", "banana", "mango" };
            var sortedWords =
                                from word in words
                                orderby word
                                select word;
            return sortedWords as List<string>;
        }

        public static List<Product> GetProductsOrderby()
        {
            List<Product> products = DBManager.GetAllProducts();

            var sortedProducts =
                                from prod in products
                                orderby prod.Quantity
                                select prod;

            return sortedProducts as List<Product>;

        }

        public static List<Product> GetProductsByDescending()
        {
            List<Product> products = DBManager.GetAllProducts();

            var sortedProducts =
                                from prod in products
                                orderby prod.Quantity descending
                                select prod;

            return sortedProducts as List<Product>;
        }

        public static List<Product> GetProductsGroupByQuantity()
        {
            List<Product> products = DBManager.GetAllProducts();

            var orderGroups =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, Products = prodGroup };

            return orderGroups as List<Product>;
        }

        public static List<string> GetProductsDistinct()
        {
            List<Product> products = DBManager.GetAllProducts();
            var categoryNames = (from prod in products
                                 select prod.Quantity).Distinct();

            return categoryNames as List<string>;

        }

        public static void ToDictionary()
        {
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                       new {Name = "Bob"  , Score = 40},
                                       new {Name = "Cathy", Score = 45}
                            };

            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);


        }

        public static Product GetFifthProduct()
        {
            List<Product> products = DBManager.GetAllProducts();
            Product product5 = products.FirstOrDefault(p => p.ID == 5);
            return product5;
        }

        public static dynamic GetProductCount()
        {
            List<Product> products = DBManager.GetAllProducts();

            var categoryCounts =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };

            return categoryCounts;
        }

        public static dynamic GetAveragePriceOfCategory()
        {
            List<Product> products = GetAllProducts();
            var categories =
                from prod in products
                group prod by prod.Quantity into prodGroup
                select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            return categories;


        }

        public static List<Product> GetAllHardcodedProducts()
        {
            List<Product> allProducts = new List<Product>();

            allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
            allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Quantity = 7000 });
            allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Quantity = 3400 });
            allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Quantity = 27000 });
            allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Quantity = 1000 });
            allProducts.Add(new Product { ID = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Quantity = 2000 });
            allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Quantity = 159 });
            allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Quantity = 67 });
            allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Quantity = 5000 });
            allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Quantity = 0 });
            allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Quantity = 0 });
            allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Quantity = 700 });
            allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Quantity = 1500 });
            allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Quantity = 2300 });
            allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Quantity = 10000 });
            return allProducts;
        }

        public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = DBManager.GetAllProducts();

            return allProducts;
        }
     */
    }

