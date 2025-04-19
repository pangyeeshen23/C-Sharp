using ClarificationAndPercision.Models;

namespace ClarificationAndPercision.Logger
{
    static class OrderLogger
    {
        public static void LogOrder(Order order)
        {
            Console.WriteLine($"Order {order.Id} logged.");
        }
    }
}
