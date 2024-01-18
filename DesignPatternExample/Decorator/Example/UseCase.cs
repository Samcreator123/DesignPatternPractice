namespace DesignPatternExample.Decorator.Example
{
    public class UseCase : IUseCase
    {
        // 無論 coffee 還是 coffeeDecorator 都繼承 ICoffee
        // coffeeDecorator SetDecorator將要裝飾的物件注入(建立關係)
        // coffeeDecorator 抽象 ICoffee 的方法定義，留給具體的Decorator實作
        public IEnumerable<string> Print()
        {
            ICoffee coffee = new Coffee(35);
            
            CoffeeDecorator coffeeWithMilk = new CoffeeWithMilk(15);
            coffeeWithMilk.SetDecorator(coffee);
            
            CoffeeDecorator coffeeWithMilkAndSuger = new CoffeeWithSugar(20);
            coffeeWithMilkAndSuger.SetDecorator(coffeeWithMilk);

            yield return "coffee : " + coffee.Cost().ToString();
            yield return "coffeeWithMilk : " + coffeeWithMilk.Cost().ToString();
            yield return "coffeeWithMilkAndSuger : " + coffeeWithMilkAndSuger.Cost().ToString();
        }
    }
}
