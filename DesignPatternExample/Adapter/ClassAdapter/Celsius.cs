namespace DesignPatternExample.Adapter.ClassAdapter
{
    //類別用繼承的方式，耦合度較高
    internal class Celsius : Fahrenheit
    {
        public Celsius(decimal degreesFahrenheit) : base(degreesFahrenheit)
        {
        }

        public decimal GetDegreesCelsius()
        {
            return (base.GetDegreesFahrenheit() - 32) * 5 / 9;
        }
    }
}
