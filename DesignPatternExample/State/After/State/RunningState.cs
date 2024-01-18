using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After.State
{
    public class RunningState : IState
    {
        private readonly Character _character;

        public RunningState(Character character)
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
            _character.SetState(_character.GetJumpingState);
            return "The character is jumping now";
        }

        public string Running()
        {
            return "The character is running now";
        }

        public string Walking()
        {
            _character.SetState(_character.GetWalkingState);
            return "The character is walking now";
        }
    }
}
