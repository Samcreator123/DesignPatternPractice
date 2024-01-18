using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    public class SeniorStrategy : IPriceStrategy
    {
        public CustomType CustomType => CustomType.SENIOR;

        public decimal CalculatePrice(decimal price)
        {
            return Math.Round(price * 0.5m);
        }
    }
}
