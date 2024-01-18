using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample
{
    public interface IUseCase
    {
        IEnumerable<string> Print();
    }
}
