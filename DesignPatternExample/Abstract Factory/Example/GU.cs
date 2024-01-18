using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class GU : IFactory
    {
        public IPants MakePants()
        {
            return new PantsOfGU();
        }

        public IShort MakeShort()
        {
            return new ShortOfGU();
        }
    }
}
