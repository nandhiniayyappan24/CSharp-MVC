namespace CSharpMvc.Services
{
    public sealed class OrderService : IOrderService
    {
        public string GetWelcomeMessage() { return "ASP.NET MVC 5 monolithic app"; }

        public decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPercent)
        {
            var subtotal = quantity * unitPrice;
            return subtotal - (subtotal * discountPercent / 100m);
        }

        public bool IsEligibleForFreeShipping(int orderTotal) { return orderTotal >= 50; }
    }
}
