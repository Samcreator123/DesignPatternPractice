using DesignPatternExample.State.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.Before
{
    public class Character
    {
        private StateCase _state = StateCase.Idle;

        public string Walking()
        {
            if (this._state == StateCase.Idle || this._state == StateCase.Walking)
            {
                this._state = StateCase.Walking;
                return "The character is now walking";
            }
            return "The character can not walking...";
        }

        public string Running()
        {
            if (this._state == StateCase.Walking || this._state == StateCase.Running)
            {
                this._state = StateCase.Running;
                return "The character is now running";
            }
            return "The character can not run...";
        }

        public string Jumping()
        {
            if (this._state == StateCase.Running || this._state == StateCase.Jumping)
            { 
                this._state = StateCase.Jumping;
                return "The character is now jumping";
            }
            return "The character can not jump...";
        }

        public string Idle()
        {
            this._state = StateCase.Idle;
            return "The character is now idle";
        }
    }
}
