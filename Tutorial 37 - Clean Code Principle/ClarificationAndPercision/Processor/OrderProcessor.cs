using ClarificationAndPercision.Models;

namespace ClarificationAndPercision.Processor
{
    // good example of method structuring
    class OrderProcessor
    {

        public void ProcessOrder(Order order)
        {
            if(IsValid(order))
            {
                SaveOrder(order);
                UpdateOrder(order);
            }
        }

        private bool IsValid(Order order)
        {
            // TODO: Validate order
            return false;
        }

        private void SaveOrder(Order order)
        {
            // TODO: Save Order logic
        }

        private void UpdateOrder(Order order)
        {
            // TODO: Update Order logic
        }
    }
}
