using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Interperter.Example
{
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return "還沒做";
        }
    }
}
