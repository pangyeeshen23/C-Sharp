using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarificationAndPercision.Logger;
using ClarificationAndPercision.Models;
using ClarificationAndPercision.Notifier;

namespace ClarificationAndPercision.Services
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();

        // Single Responsibility Principle :
        // As you can see her the OrderService class is responsible for only one thing
        // which is to manage the orders. It does not handle logging or notifying customers.
        // so we should create a new class for each of these responsibilities.
        // and not to put them in the service layer class.
        public void AddOrder(Order order)
        {
            orders.Add(order);
            OrderLogger.LogOrder(order);
            OrderNotifier.NotifyCustomer(order);
        }
    }
}
