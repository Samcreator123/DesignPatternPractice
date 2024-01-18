using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Command.Share
{
    public interface ILight
    {
        public string On();

        public string Off();
    }
}
