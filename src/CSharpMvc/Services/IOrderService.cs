namespace CSharpMvc.Services;

public interface IOrderService
{
    string GetWelcomeMessage();
    decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPercent);
    bool IsEligibleForFreeShipping(int orderTotal);
}
