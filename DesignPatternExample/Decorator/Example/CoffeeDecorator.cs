namespace DesignPatternExample.Decorator.Example
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected decimal _decoratorCost;
        protected ICoffee _coffee;

        public CoffeeDecorator(decimal decoratorCost)
        {
            this._decoratorCost = decoratorCost;
        }

        public void SetDecorator(ICoffee coffee)
        {
            this._coffee = coffee;
        }

        public abstract decimal Cost();
    }
}
