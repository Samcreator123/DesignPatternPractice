using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.After
{
    public class TurnOnCommand : ICommand
    {
        private ILight _light;

        public TurnOnCommand(ILight light)
        {
            this._light = light;
        }
        public string Execute()
        {
            return _light.On();
        }
    }
}
