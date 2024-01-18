using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class Uniqlo : IFactory
    {
        public IPants MakePants() 
        {
            return new PantsOfUniqlo();
        }
        public IShort MakeShort()
        {
            return new ShortOfUniqlo();
        }
    }
}
