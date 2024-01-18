using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    public interface IFactory
    {
        IPants MakePants();

        IShort MakeShort();
    }
}
