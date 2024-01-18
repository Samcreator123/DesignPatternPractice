using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.After
{
    public class FactoryTwo : IFactory
    {
        public IPhone ProducePhone()
        {
            return new PhoneTwo(new Screen(), new SomeHardware());
        }
    }
}
