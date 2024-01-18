using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Bridge.After
{
    public interface IPayment
    {
        bool ProcessPayment(int cost);
    }
}
