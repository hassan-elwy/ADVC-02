using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11.Products
{
    public static class ProductHelper
    {

        public static List<Product> Search(List<Product> products, Func<Product,bool >result)
        {
            List<Product> FilteredProducts=new List<Product>();
          
            for(int i=0; i < products.Count; i++)
            {
                if(result.Invoke(products[i]))
                {
                    FilteredProducts.Add(products[i]);
                }
                
            }
            return FilteredProducts;
        }

        public static void ViewListProduct(List<Product> products,String Title)
        {
            Console.WriteLine($"----{Title}----");
            for(int i=0;i<products.Count;i++)
            {
                products[i].PrintDetailedReport();
            }

            Console.WriteLine();


        }
        public static void printReport(List<Product> products, Action action)
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                products[i].PrintDetailedReport();
            }

            Console.WriteLine();


        }

    }
}
