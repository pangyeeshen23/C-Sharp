using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarificationAndPercision.Models;

namespace ClarificationAndPercision.Notifier
{
    static class OrderNotifier
    {
        public static void NotifyCustomer(Order order)
        {
            Console.WriteLine($"Cutomer notified for oder {order.Id}.");
        }
    }
}
