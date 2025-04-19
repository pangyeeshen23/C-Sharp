using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarificationAndPercision.Principles.Printer;

namespace ClarificationAndPercision.Principles
{
    class KissPrinciple
    {
        public void Main()
        {
            OrderPrinter orderPrinter = new OrderPrinter();
            orderPrinter.PrintOrderDetails(new List<Order>() { 
                new Order()
                {
                    Id = 1,
                    ProductName = "Product A",
                    Quantity = 2,
                    Price = 10.0m,
                    Total = 20.0m
                },
            });
        }
    }
}
