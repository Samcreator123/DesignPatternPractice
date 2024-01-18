using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Flyweight.After
{
    public class CircleFlyweight : IShape
    {
        private string _color;

        public CircleFlyweight(string color)
        { 
            this._color = color;
        }

        public string Draw(int x, int y, int radius)
        {
            return $"Draw a circle of color {_color} at position ({x},{y}) with radius {radius}";
        }
    }
}
