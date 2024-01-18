using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    internal class ActivityStrategy : IPriceStrategy
    {
        public CustomType CustomType => CustomType.ACTIVITY;

        public decimal CalculatePrice(decimal price)
        {
            return Math.Round(price * 0.75m);
        }
    }
}
