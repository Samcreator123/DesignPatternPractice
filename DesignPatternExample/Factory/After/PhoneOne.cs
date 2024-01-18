using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.After
{
    public class PhoneOne : IPhone
    {
        Screen _screen;
        SomeHardware _someHardware;
        public PhoneOne(Screen screen, SomeHardware someHardware) 
        {
            _screen = screen;
            _someHardware = someHardware;
        }

        public string PowerOff()
        {
            return "phone one power off...";
        }

        public string PowerOn()
        {
            return "pheon one power on...";
        }
    }
}
