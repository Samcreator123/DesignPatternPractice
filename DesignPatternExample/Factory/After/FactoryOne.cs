using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.After
{
    public class FactoryOne : IFactory
    {
        public IPhone ProducePhone()
        {
            return new PhoneOne(new Screen(), new SomeHardware());
        }
    }
}
