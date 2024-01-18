using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Flyweight.After
{
    public class CircleFactory
    {
        private readonly static Dictionary<string, CircleFlyweight> _circleMap = new Dictionary<string, CircleFlyweight>();

        public static CircleFlyweight GetCircle(string color)
        {

            if (_circleMap.TryGetValue(color, out _)) return _circleMap[color];

            CircleFlyweight circle = new CircleFlyweight(color);

            _circleMap.Add(color, circle);

            return circle;
        }
    }
}
