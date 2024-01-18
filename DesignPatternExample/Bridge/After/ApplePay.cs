using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Bridge.After
{
    public class ApplePay : IPayment
    {
        int _balance;
        public ApplePay(int balance)
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
