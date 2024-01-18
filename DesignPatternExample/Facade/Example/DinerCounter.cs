using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Facade.Example
{
    /// <summary>
    /// 櫃檯人員負責點餐
    /// </summary>
    public class DinerCounter
    {
        public string Order()
        {
            return "確認餐點內容，您點的是...";
        }

        public void NotifyCooker() { }

        public string Check()
        {
            return "今天用餐總共是...元";
        }
    }
}
