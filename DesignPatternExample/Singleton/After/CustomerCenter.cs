using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Singleton.After
{
    internal class CustomerCenter
    {
        private static CustomerCenter _instance;

        bool _isHoliday;

        //防止創造多個實例
        private CustomerCenter() { }

        public static CustomerCenter GetCustomerCenter()
        {
            //如果 _instance是null 則返回 new CustomerCenter() 否則 _instance是null
            _instance ??= new CustomerCenter();

            return _instance;
        }
        public void SetHoliday(bool isHoliday)
        {
            _instance._isHoliday = isHoliday;
        }

        public string IsHoliday()
        {
            return _instance._isHoliday ? "yes" : "no";
        }
    }
}
