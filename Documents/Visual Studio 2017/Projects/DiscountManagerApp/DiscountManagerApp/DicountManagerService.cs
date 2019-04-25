using System;

namespace DiscountManagerApp
{
    public enum AccountStatus
    {
        NotRegistered = 1,
        SimpleCustomer = 2,
        ValuableCustomer = 3,
        MostValuableCustomer = 4
    }

    public static class Constants
    {
        public const int MAXIMUM_DISCOUNT_FOR_LOYALTY = 5;
        public const decimal DISCOUNT_FOR_SIMPLE_CUSTOMERS = 0.9m;
        public const decimal DISCOUNT_FOR_VALUABLE_CUSTOMERS = 0.7m;
        public const decimal DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS = 0.5m;
    }

    public class DiscountManagerService : IDiscountManagerService
    {
        public decimal ApplyDiscount(decimal price, AccountStatus accountType, int yearsSinceRegistration)
        {
            decimal result = 0;
            decimal priceForRegisteredUser = GetDiscountPriceForRegisteredUser(price, yearsSinceRegistration);

            switch (accountType)
            {
                case AccountStatus.NotRegistered:
                    result = price;
                    break;

                case AccountStatus.SimpleCustomer:
                    result = priceForRegisteredUser * Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS;
                    break;

                case AccountStatus.ValuableCustomer:
                    result = priceForRegisteredUser * Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS;
                    break;

                case AccountStatus.MostValuableCustomer:
                    result = priceForRegisteredUser * Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS;
                    break;

                default:
                    throw new NotImplementedException("Typ nie je podporovaný");
                    break;

            }

            return result;
        }

        private decimal GetDiscountPriceForRegisteredUser(decimal price, int yearsSinceRegistration)
            => price * (1 - GetDiscountByYearOfRegistration(yearsSinceRegistration));

        private decimal GetDiscountByYearOfRegistration(int yearsSinceRegistration)
        {
            return (yearsSinceRegistration > Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY)
                ? (decimal)Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100
                : (decimal)yearsSinceRegistration / 100;
        }

    }
}
