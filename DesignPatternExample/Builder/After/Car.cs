using DesignPatternExample.Builder.Share;

namespace DesignPatternExample.Builder.After
{
    public class Car
    {
        GPS _gps;
        HeatedSW _heatedSW;
        Sunroof _sunroof;

        public Car() { }

        public void GetGPS()
        {
            _gps = new GPS();
        }

        public void GetHeatedSW()
        {
            _heatedSW = new HeatedSW();
        }

        public void GetSunroof()
        {
            _sunroof = new Sunroof();
        }
    }
}
