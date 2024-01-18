using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After.State
{
    public class IdleState : IState
    {
        private readonly Character _character;

        public IdleState(Character character)
        {
            _character = character;
        }

        public string Idle()
        {
            return "The character is now idle";
        }

        public string Jumping()
        {
            return "The character can not walk now";
        }

        public string Running()
        {
            return "The character can not run now";
        }

        public string Walking()
        {
            _character.SetState(_character.GetWalkingState);
            return "The character is walking now";
        }
    }
}
