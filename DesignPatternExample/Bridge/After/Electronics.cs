namespace DesignPatternExample.Bridge.After
{
    //注入payment後，依靠注入的payment提供實作，不需要因為增加新的payment而新增一個function
    //相較原本的 新增一個類別與function少掉新增一個function

    //可得知 在新增功能時，若新功能與舊功能傳入的物件有相同的行為，可取抽象至建構子注入或方法注入(builder)
    //並且如果新功能與舊功能差別只在傳入的物件，則可以像範例一樣少新增一個function
    public class Electronics
    {
        int _cost;
        IPayment payment;
        public Electronics(int cost, IPayment payment)
        {
            _cost = cost;
            this.payment = payment;
        }
        public string Purchase()
        {
            return payment.ProcessPayment(this._cost) ? $"成功付款 {this._cost}" : $"付款失敗 {this._cost}";

        }
    }
}
