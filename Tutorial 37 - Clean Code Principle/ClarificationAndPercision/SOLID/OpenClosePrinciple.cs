namespace ClarificationAndPercision.SOLID
{
    class OpenClosePrinciple
    {
        public static void Main()
        {
            Invoice invoice = new Invoice { Amount = 100 };
            DiscountedInvoice discountedInvoice = new DiscountedInvoice { Amount = 100, Discount = 10 };
            BillingService billingService = new BillingService();
            decimal total = billingService.CalculateTotal(invoice);
            decimal totalDiscountAmount = billingService.CalculateTotal(discountedInvoice);
            Console.WriteLine($"Total: {total}");
        }
    }

    public class Invoice
    {
        public decimal Amount { get; set; }
    }

    // Open-Closed Principle: As you can see the we had extended an entity to add in new properties
    // and we did not change the existing code. So this is a good example of open-closed principle.
    // which is to open for extension and closed for modification.
    // a good benefit can be seen on the above code which we can reused the function from billing service to get the total
    public class DiscountedInvoice : Invoice
    {
        public decimal Discount { get; set; }
    }

    public class BillingService
    {
        public virtual decimal CalculateTotal(Invoice invoice)
        {
            return invoice.Amount;
        }
    }
}
