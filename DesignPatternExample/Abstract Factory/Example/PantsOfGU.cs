using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    internal class PantsOfGU : IPants
    {
        public string MakeFrom()
        {
            return "GU";
        }
    }
}
