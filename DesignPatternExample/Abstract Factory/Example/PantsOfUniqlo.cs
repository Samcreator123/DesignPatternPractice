using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class PantsOfUniqlo : IPants
    {
        public string MakeFrom()
        {
            return "GU";
        }
    }
}
