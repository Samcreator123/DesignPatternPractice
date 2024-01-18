using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    public class AdultStrategy : IPriceStrategy
    {
        public CustomType CustomType => CustomType.ADULT;

        public decimal CalculatePrice(decimal price)
        {
            return Math.Round(price);
        }
    }
}
