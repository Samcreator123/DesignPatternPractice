using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Facade.Example
{
    /// <summary>
    /// 負責接待與送餐
    /// </summary>
    public class Waiter
    {
        public string Reception()
        {
            return "這邊幫您帶位";
        }

        public void Clear() { }

        public string DeliverFood() 
        {
            return "您的餐點...";
        }
    }
}
