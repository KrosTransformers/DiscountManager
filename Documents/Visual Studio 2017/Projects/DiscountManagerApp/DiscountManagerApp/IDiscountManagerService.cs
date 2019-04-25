namespace DiscountManagerApp
{
    public interface IDiscountManagerService
    {
        decimal ApplyDiscount(decimal price, AccountStatus accountType, int yearsSinceRegistration);
    }
}
