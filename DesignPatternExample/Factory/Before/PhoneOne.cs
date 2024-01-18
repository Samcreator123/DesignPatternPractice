using DesignPatternExample.Factory.Share;

namespace DesignPatternExample.Factory.Before
{
    internal class PhoneOne : IPhone
    {
        private readonly Hardware _hardware;
        public PhoneOne(Hardware hardware) 
        { 
            this._hardware = hardware;
        }

        public string PowerOff()
        {
            return "power off...";
        }

        public string PowerOn()
        {
            return "power on...";
        }
    }
}
