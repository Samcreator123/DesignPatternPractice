using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    /// <summary>
    /// 策略模式裡的 Strategy 策略
    /// </summary>
    public interface IPriceStrategy
    {
        CustomType CustomType { get; }

        decimal CalculatePrice(decimal price);
    }
}
