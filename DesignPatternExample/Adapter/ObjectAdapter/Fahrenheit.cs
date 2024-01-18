using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Adapter.ObjectAdapter
{
    internal class Fahrenheit
    {
        decimal _degreesFahrenheit;
        public Fahrenheit(decimal degreesFahrenheit)
        {
            this._degreesFahrenheit = degreesFahrenheit;
        }

        public decimal GetDegreesFahrenheit()
        {
            return _degreesFahrenheit;
        }
    }
}
