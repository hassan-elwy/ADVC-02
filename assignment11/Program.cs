using assignment11.Products;

namespace assignment11
{
    internal class Program
    {

        public static void task1()
        {
            ProductCatalog catalogs = new ProductCatalog();
            List<List<Product>> Results = new List<List<Product>>();

            Results.Add(ProductHelper.Search(catalogs.GetProducts(), (Product x) => { return x.Category == "Electronics"; }));
            ProductHelper.ViewListProduct(Results[Results.Count - 1], "Electronics");
            Results.Add(ProductHelper.Search(catalogs.GetProducts(), (Product x) => { return x.Price < 50; }));
            ProductHelper.ViewListProduct(Results[Results.Count - 1], "Under 50");
            Results.Add(ProductHelper.Search(catalogs.GetProducts(), (Product x) => { return x.Stock>0; }));
            ProductHelper.ViewListProduct(Results[Results.Count - 1], "In Stocks");
            Results.Add(ProductHelper.Search(catalogs.GetProducts(), (Product x) => { return x.Category== "Clothing" &&x.Price<100; }));
            ProductHelper.ViewListProduct(Results[Results.Count - 1], "Clothing under 100");




        }
        
        public static void task2()
        {
            ProductCatalog catalog = new ProductCatalog();
            

            Console.WriteLine("-- short report--");
            ProductHelper.printReport(catalog.GetProducts(), (Product x)=>{ x.PrintShortReport(); });

            Console.WriteLine("--Detailed report--");
            ProductHelper.printReport(catalog.GetProducts(), (Product x) => { x.PrintDetailedReport(); });
        }
       
        public static void task3()
        {
            ProductCatalog catalog = new ProductCatalog();
            List<Product> products = catalog.GetProducts();
            String result = "";


            Console.WriteLine("---Summary list---");
            result = ProductHelper.ProductTransform(products, (List<Product> p) => { return ProductHelper.SummaryList(p); });
            Console.WriteLine(result);

            Console.WriteLine("----Price Label---");
            result=ProductHelper.ProductTransform(products,(List<Product>p)=> { return ProductHelper.PriceLabels(p); });
            Console.WriteLine(result);

        }
       
        
        public static void task4()
        {
            ProductCatalog catalog = new ProductCatalog();
            List<Product> products = catalog.GetProducts();

            ProductHelper.filterProduct(products, x => x.Stock < 20);

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("\n==============================================\n");
            task1();
            Console.WriteLine("\n==============================================\n");
            task2();
            Console.WriteLine("\n==============================================\n");
            task3();
            Console.WriteLine("\n==============================================\n");
            task4();

        }
    }
}
