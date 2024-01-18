using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.After
{
    public class Invoker
    {
        List<ILight> _lightCommands = new List<ILight>();

        public string On(ILight light)
        {
            _lightCommands.Add(light);
            return light.On();
        }
        public string Off(ILight light) 
        {
            if (_lightCommands.Count == 0)
            {
                return "There is no light on";
            }

            // 可在這邊記log、計算時間等等...，將這些外部邏輯與商業邏輯分別
            _lightCommands.Remove(light);

            return light.Off();
        }
    }
}
