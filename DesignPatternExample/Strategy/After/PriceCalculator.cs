using DesignPatternExample.Strategy.Share;

namespace DesignPatternExample.Strategy.After
{
    /// <summary>
    /// 策略模式裡的 Context 上下文
    /// </summary>
    public class PriceCalculator
    {
        public static string GetPrice(IPriceStrategy priceStrategy, decimal originPrice)
        {
            return $"總共為 {priceStrategy.CalculatePrice(originPrice)} 元";
        }
    }
}
