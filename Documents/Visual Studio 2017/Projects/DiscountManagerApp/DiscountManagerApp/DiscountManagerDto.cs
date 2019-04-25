namespace DiscountManagerApp
{
    public class DiscountManagerDto
    {
        public decimal Amount { get; set; }

        public int Years { get; set; }

        public AccountStatus Type { get; set; }
    }
}