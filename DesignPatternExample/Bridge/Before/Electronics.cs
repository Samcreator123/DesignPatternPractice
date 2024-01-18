namespace DesignPatternExample.Bridge.Before
{
    //若增加一個付款方式要新增一個類別與一個function
    public class Electronics
    {
        int _cost;
        public Electronics(int cost)
        {
            _cost = cost;
        }
        public string PurchaseWithLinePay(LinePay linePay)
        {
            return linePay.ProcessPayment(this._cost) ? $"成功付款 {this._cost}" : $"付款失敗 {this._cost}";

        }
        public string PurchaseWithApplePay(ApplePay applePay)
        {
            return applePay.ProcessPayment(this._cost) ? $"成功付款 {this._cost}" : $"付款失敗 {this._cost}";
        }
    }
}
