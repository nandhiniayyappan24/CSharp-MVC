namespace CSharpMvc.Services;

public sealed class RetailOrderProcessor
{
    public decimal Process(int quantity, decimal unitPrice, decimal discountPercent)
    {
        var subtotal = quantity * unitPrice;
        return subtotal - (subtotal * discountPercent / 100m);
    }
}
