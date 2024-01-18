namespace DesignPatternExample.Command.After
{
    // 可進行對多數Command的操作，也可自由調整Command的順序
    public class Invoker
    {
        List<ICommand> _lightCommands = new List<ICommand>();

        public void AddLightCommand(ICommand command)
        {
            this._lightCommands.Add(command);
        }

        public IEnumerable<string> Execute()
        {
            foreach (var command in this._lightCommands)
            {
                yield return command.Execute();
            }
        }
    }
}
