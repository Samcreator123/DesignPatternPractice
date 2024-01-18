using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Singleton.Before
{
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        { 
            CustomerCenter customerCenter1 = new CustomerCenter();
            customerCenter1.SetHoliday(true);
            yield return customerCenter1.IsHoliday();
            yield return customerCenter1.IsHoliday();
            yield return customerCenter1.IsHoliday();

            CustomerCenter customerCenter2 = new CustomerCenter();
            customerCenter2.SetHoliday(false);
            yield return customerCenter2.IsHoliday();
            yield return customerCenter2.IsHoliday();
            yield return customerCenter2.IsHoliday();
            //希望CustomerCenter只能有一個 故這邊希望也是no
            yield return customerCenter1.IsHoliday();
        }
    }
}
