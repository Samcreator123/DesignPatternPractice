using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    public class ChildStrategy : IPriceStrategy
    {
        public CustomType CustomType => CustomType.CHILD;

        public decimal CalculatePrice(decimal price)
        {
            return Math.Round(price * 0.6m);
        }
    }
}
