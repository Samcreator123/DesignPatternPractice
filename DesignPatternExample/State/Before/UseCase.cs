namespace DesignPatternExample.State.Before
{
    /// <summary>
    /// 沒使用狀態模式的情形下，角色的行為一但複雜起來，將會變得麻煩.
    /// 並且關注點沒有達到明確的分離.
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
