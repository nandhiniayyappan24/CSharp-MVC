namespace CSharpMvc.Services;

public sealed class OrderService : IOrderService
{
    public string GetWelcomeMessage() => "ASP.NET Core MVC monolithic app";

    public decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPercent)
    {
        var subtotal = quantity * unitPrice;
        return subtotal - (subtotal * discountPercent / 100m);
    }

    public bool IsEligibleForFreeShipping(int orderTotal) => orderTotal >= 50;
}
