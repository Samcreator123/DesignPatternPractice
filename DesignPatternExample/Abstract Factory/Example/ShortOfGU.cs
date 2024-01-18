using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class ShortOfGU : IShort
    {
        public string MakeFrom()
        {
            return "Uniqlo";
        }
    }
}
