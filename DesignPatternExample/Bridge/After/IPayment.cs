using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Bridge.After
{
    public interface IPayment
    {
        // 這邊違反 CQS 的原則
        bool ProcessPayment(int cost);
    }
}
