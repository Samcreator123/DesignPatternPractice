using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After.State
{
    public interface IState
    {
        string Idle();

        string Walking();
        
        string Running();
        
        string Jumping();
    }
}
