using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.After
{
    public class TurnOffCommand : ICommand
    {
        private ILight _light;

        public TurnOffCommand(ILight light)
        {
            this._light = light;
        }

        public string Execute()
        {
            return _light.Off();
        }
    }
}
