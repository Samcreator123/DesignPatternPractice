using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Bridge.After
{
    public class LinePay : IPayment
    {
        int _balance;
        public LinePay(int balance)
        {
            _balance = balance;
        }

        public bool ProcessPayment(int cost)
        {
            if (cost > this._balance) return false;

            this._balance -= cost;

            return true;
        }
    }
}
