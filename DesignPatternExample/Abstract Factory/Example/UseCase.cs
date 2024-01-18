using DesignPatternExample.Abstract_Factory.Share;

namespace DesignPatternExample.Abstract_Factory.Example
{
    //使用抽象工廠生產一系列的商品，使用者只要確保他工廠類別就能得到一系列相同的產品
    //不會發生我要GU的褲子結果拿到Uniqlo的褲子
    internal class User1
    {
        IPants? _pants;
        IShort? _short;
        public void GetClothes()
        {
            IFactory factory = new Uniqlo();
            _pants = factory.MakePants();
            _short = factory.MakeShort();
            _pants.MakeFrom();
            _short.MakeFrom();
        }
    }

    internal class User2
    {
        IPants? _pants;
        IShort? _short;
        public void GetClothes()
        {
            IFactory factory = new GU();
            _pants = factory.MakePants();
            _short = factory.MakeShort();
            _pants.MakeFrom();
            _short.MakeFrom();
        }
    }
}
