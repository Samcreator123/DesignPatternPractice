using DesignPatternExample.State.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After.State
{
    public class JumpingState : IState
    {
        readonly Character _character;

        public JumpingState(Character character) 
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
            return "The character is jumping now";
        }

        public string Running()
        {
            _character.SetState(_character.GetRunningState);
            return "The character is running now";
        }

        public string Walking()
        {
            return "The character can not walk now";
        }
    }
}
