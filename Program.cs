using System;
using System.Linq;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>(); 
            {
                transactions.Add(("Hammer", 8.35, 1));
                transactions.Add(("ScrewDriver", 4.29, 1));
                transactions.Add(("PaintBrush", 3.29, 2));
                transactions.Add(("Candy", .99, 1));
                transactions.Add(("Crowbar", 5.00, 1));
            }
            
            

            List<double> amountList = new List<double>();
            List<int> productList = new List<int>();
            



            foreach((string product, double amount, int quantity) item in transactions)
            {
            //multiply amount and quantity together.
            amountList.Add(item.amount * item.quantity);
            productList.Add(item.quantity);
            }
            double totalAmount = amountList.Sum();
            int totalProduct = productList.Sum();

            Console.WriteLine(totalAmount.ToString("f2"));
            Console.WriteLine(totalProduct);
        }
    }
}
