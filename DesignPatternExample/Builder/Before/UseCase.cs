using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Builder.Before
{
    internal class UseCase
    {
        public void GetCarWithHeatedSW()
        {
            Car car = new Car(false, true, false);
        }

        public void GetCarWithHeatedSWAndGPS()
        {
            Car car = new Car(true, true, false);
        }
    }
}
