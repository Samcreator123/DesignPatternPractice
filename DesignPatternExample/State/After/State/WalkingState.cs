using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After.State
{
    public class WalkingState : IState
    {
        private readonly Character _character;

        public WalkingState(Character character)
        { 
            this._character = character;
        }

        public string Idle()
        {
            _character.SetState(_character.GetIdleState);
            return "The character is now idle";
        }

        public string Jumping()
        {
            return "The character can not jump now";
        }

        public string Running()
        {
            _character.SetState(_character.GetRunningState);
            return "The character is running now";
        }

        public string Walking()
        {
            return "The character is walking now";
        }
    }
}
