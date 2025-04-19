using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarificationAndPercision.Models;

namespace ClarificationAndPercision.Principles.Printer
{
    class OrderPrinter
    {

        // Bad examples
        public void PrintOrderDetails(List<Order> orders)
        {
            decimal totalPrice = 0;

            foreach(var order in orders)
            {
                decimal total = order.Quantity * order.Price;
                if (order.Quantity > 0 && order.Price > 0)
                {
                    Console.WriteLine("Order ID :" + order.Price);
                    Console.WriteLine("Product :" + order.ProductName);
                    Console.WriteLine("Quantity :" + order.Quantity);
                    Console.WriteLine("Price :" + order.Price);
                    Console.WriteLine("Total :" + order.Total);
                    Console.WriteLine("------------");

                }
            }

            foreach (var order in orders)
            {
                if(order.Quantity > 0 && order.Price > 0)
                {
                    totalPrice += order.Quantity * order.Price;
                }
            }
            Console.WriteLine("Total Price :" + totalPrice);
        }

        // Good examples
        public void PrintOrderDetailsKISS(List<Order> orders)
        {
            decimal totalPrice = 0;

            foreach (var order in orders)
            {
                totalPrice += order.Quantity * order.Price;
                decimal total = order.Quantity * order.Price;
                if (order.Quantity > 0 && order.Price > 0)
                {
                    Console.WriteLine("Order ID :" + order.Price);
                    Console.WriteLine("Product :" + order.ProductName);
                    Console.WriteLine("Quantity :" + order.Quantity);
                    Console.WriteLine("Price :" + order.Price);
                    Console.WriteLine("Total :" + order.Total);
                    Console.WriteLine("------------");

                }
            }
            Console.WriteLine("Total Price :" + totalPrice);
        }
    }

    class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; } 
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
