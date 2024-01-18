using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Decorator.Example
{
    public class Coffee : ICoffee
    {
        decimal _cost;
        public Coffee(decimal cost)
        {
            this._cost = cost;
        }

        public decimal Cost()
        {
            return _cost;
        }
    }
}
