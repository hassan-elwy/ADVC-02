using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
        public static void printReport(List<Product> products, Action<Product> action)
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                action.Invoke(products[i]);
            }

            Console.WriteLine();


        }

        public static string ProductTransform(List<Product> products,Func<List<Product>,string> fun)
        {
            return fun.Invoke(products);
        }

        public static string SummaryList(List<Product> products)
        {
            string s="";
            for (int i = 0; i < products.Count; i++)
            {
                s+=$"{products[i].Name} ({products[i].Price})\n";
            }

            return s;
    
        }

        public static string PriceLabels(List<Product> products)
        {
            string s = "";
            for (int i = 0; i < products.Count; i++)
            {
                s+=products[i].PriceLabel();
            }

            return s;

        }

    }
}
