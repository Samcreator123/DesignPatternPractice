using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.State.After
{
    /// <summary>
    /// 使用狀態模式，達到關注點分離。
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            Character character = new();

            yield return character.Idle();
            yield return character.Walking();
            yield return character.Jumping();
            yield return character.Idle();
            yield return character.Walking();
            yield return character.Running();
            yield return character.Jumping();

        }
    }
}
