using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.After
{
    //建立工廠類 封裝製造手機的複雜過程
    //使得使用者只要引用工廠便可取得手機，不需要了解複雜的製造過程
    internal class User1
    {
        private IPhone _phone;
        public void GetPhone()
        {
            this._phone = new FactoryOne().ProducePhone();
        }
    }
    internal class User2
    {
        private IPhone _phone;
        public void GetPhone()
        {
            this._phone = new FactoryTwo().ProducePhone();
        }
    }
}
