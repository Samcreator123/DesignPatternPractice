using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.Before
{
    //若讓使用者(User1、User2)要了解Phone的製造過程
    //則phone如果製造過程變複雜
    //則用戶端都要改動
    internal class User1
    {
        private IPhone _phone;
        public void GetPhone()
        {
            this._phone = new PhoneOne(new Hardware());
        }
    }
    internal class User2 
    {
        private IPhone _phone;
        public void GetPhone()
        {
            this._phone = new PhoneOne(new Hardware());
        }
    }

}
