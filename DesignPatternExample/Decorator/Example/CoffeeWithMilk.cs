namespace DesignPatternExample.Decorator.Example
{
    public class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(decimal decoratorCost) : base(decoratorCost)
        {
        }
        public override decimal Cost()
        {
            // add milk...
            return _coffee.Cost() + this._decoratorCost;
        }
    }
}
