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
            

            Console.WriteLine("--short report");
            ProductHelper.printReport(catalog.GetProducts(), (Product x)=>{ x.PrintShortReport(); });

            Console.WriteLine("--Detailedreport");
            ProductHelper.printReport(catalog.GetProducts(), (Product x) => { x.PrintDetailedReport(); });
        }
        static void Main(string[] args)
        {
            task2();

        }
    }
}
