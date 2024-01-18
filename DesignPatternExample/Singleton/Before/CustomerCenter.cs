using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Singleton.Before
{
    public class CustomerCenter
    { 
        bool _isHoliday;

        public void SetHoliday(bool isHoliday)
        { 
            _isHoliday = isHoliday;
        }

        public string IsHoliday()
        {
            return _isHoliday ? "yes" : "no";
        }
    }
}
