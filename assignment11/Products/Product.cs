using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11.Products
{


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } 
        public double Price { get; set; }
        public int Stock { get; set; }

        public void PrintDetailedReport()
        {
            Console.WriteLine($"{Name} - {Price} ( Stocks: {Stock})");
        }

        public void PrintShortReport()
        {
            Console.WriteLine($"{Name} - {Price} ");
        }

        public string PriceLabel()
        {
            return $"{Name} : {(Price > 100 ? "Expensive!" : "Affordable")}\n";
         


        }
        
    }
}
