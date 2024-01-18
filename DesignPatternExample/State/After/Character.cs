using DesignPatternExample.State.After.State;
using DesignPatternExample.State.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After
{
    public class Character
    {
        IState _state;

        //先準備好 避免切換狀態時需要重新建立實例;
        public IdleState GetIdleState { get; init; }
        public WalkingState GetWalkingState{ get; init; }
        public RunningState GetRunningState{ get; init; }
        public JumpingState GetJumpingState { get; init; }


        public Character()
        {
            this.GetIdleState = new IdleState(this);
            this.GetWalkingState = new WalkingState(this);
            this.GetRunningState = new RunningState(this);
            this.GetJumpingState = new JumpingState(this);

            _state = new IdleState(this);
        }

        public string Idle()
        {
            return _state.Idle();
        }

        public string Walking()
        {
            return _state.Walking();
        }

        public string Running()
        {
            return _state.Running();
        }

        public string Jumping()
        {
            return _state.Jumping();
        }

        public void SetState(IState state)
        { 
            _state = state;
        }
    }
}
