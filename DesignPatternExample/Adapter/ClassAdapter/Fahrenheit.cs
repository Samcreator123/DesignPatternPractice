namespace DesignPatternExample.Adapter.ClassAdapter
{
    internal class Fahrenheit
    {
        decimal _degreesFahrenheit;
        public Fahrenheit(decimal degreesFahrenheit) 
        {
            this._degreesFahrenheit = degreesFahrenheit;
        }
        
        public decimal GetDegreesFahrenheit() 
        {
            return _degreesFahrenheit;
        }
    }
}
