using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Bridge.After
{
    public class Book
    {
        int _cost;
        //注入payment後，依靠注入的payment提供實作，不需要因為增加新的payment而新增一個function
        //相較原本的 新增一個類別與function少掉新增一個function
        IPayment payment;
        public Book(int cost, IPayment payment)
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
