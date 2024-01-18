namespace DesignPatternExample.Decorator.Example
{
    public class CoffeeWithSugar : CoffeeDecorator
    {
        public CoffeeWithSugar(decimal decoratorCost) : base(decoratorCost)
        {
        }
        public override decimal Cost()
        {
            // add sugar...
            return _coffee.Cost() + this._decoratorCost;
        }
    }
}
