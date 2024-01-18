using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Flyweight.Before
{
    public class Circle
    {
        public string? Color { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set; }

        public string Draw()
        {
            return $"Draw a circle of color {Color} at position ({X},{Y}) with radius {Radius}";
        }
    }
}
