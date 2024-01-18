using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Adapter.ObjectAdapter
{
    //物件用組合的方式
    internal class Celsius
    {
        Fahrenheit _fahrenheit;
        public Celsius(Fahrenheit fahrenheit)
        { 
            _fahrenheit = fahrenheit;
        }
        public decimal GetDegreesCelsius()
        {
            return (_fahrenheit.GetDegreesFahrenheit() - 32) * 5 / 9;
        }
    }
}
