using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Facade.Example
{
    public class DinerFacade
    {
        public IEnumerable<string> Order()
        { 
            DinerCounter dinerCounter = new DinerCounter();
           
            //點餐
            yield return dinerCounter.Order();

            //通知廚師
            dinerCounter.NotifyCooker();

            Waiter waiter = new Waiter();

            //接待
            yield return waiter.Reception();

            //送餐
            yield return waiter.DeliverFood();
        }

        public IEnumerable<string> PayForMeal()
        { 
            DinerCounter dinerCounter = new DinerCounter();
            
            //結帳
            yield return dinerCounter.Check();

            Waiter waiter = new Waiter();
            
            //清理
            waiter.Clear();
        }


    }
}
