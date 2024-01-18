namespace DesignPatternExample.Builder.After
{
    internal class UseCase
    {
        public void GetCarWithHeatedSW()
        {
            Car car = new Car();
            car.GetHeatedSW();
        }

        public void GetCarWithHeatedSWAndGPS()
        {
            Car car = new Car();
            car.GetHeatedSW();
            car.GetGPS();
        }
    }
}
