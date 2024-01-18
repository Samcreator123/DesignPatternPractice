using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.After
{
    public class PhoneTwo : IPhone
    {
        Screen _screen;
        SomeHardware _someHardware;
        public PhoneTwo(Screen screen, SomeHardware someHardware)
        {
            _screen = screen;
            _someHardware = someHardware;
        }

        public string PowerOff()
        {
            return "phone two power off...";
        }

        public string PowerOn()
        {
            return "phone two power on...";
        }
    }
}
