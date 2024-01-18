namespace DesignPatternExample.Strategy.After
{
    /// <summary>
    /// 使用介面、繼承(Strategy)讓計算價格的行為定義出來，並讓策略類(ConcreteStrategy)實作、繼承.
    /// 再將策略類放入執行策略的物件(Context)執行策略，定義封裝行為並丟到一個執行策略的物件(Context)裡面，則為策略模式
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return PriceCalculator.GetPrice(new ActivityStrategy(), 100);
            yield return PriceCalculator.GetPrice(new AdultStrategy(), 100);
            yield return PriceCalculator.GetPrice(new SeniorStrategy(), 100);
            yield return PriceCalculator.GetPrice(new AdultStrategy(), 100);
            yield return PriceCalculator.GetPrice(new ChildStrategy(), 100);
            yield return PriceCalculator.GetPrice(new ChildStrategy(), 100);

        }
    }
}
