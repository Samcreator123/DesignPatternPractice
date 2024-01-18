using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Prototype.Share
{
    public interface IPrototype 
    {
        T Copy<T>() where T : class; 
    }
}
