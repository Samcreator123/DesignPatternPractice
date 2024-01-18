using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class ShortOfUniqlo : IShort
    {
        public string MakeFrom()
        {
            return "Uniqlo";
        }
    }
}
