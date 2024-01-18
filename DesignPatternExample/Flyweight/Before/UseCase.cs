using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Flyweight.Before
{
    /// <summary>
    /// 每個圓形都需要實作一次new，數量一多消耗內存
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return new Circle() { X = 5, Y = 5, Radius = 60, Color = "red" }.Draw();

            yield return new Circle() { X = 6, Y = 50, Radius = 60, Color = "blue" }.Draw();

            yield return new Circle() { X = 7, Y = 80, Radius = 60, Color = "green" }.Draw();

            yield return new Circle() { X = 70, Y = 80, Radius = 60, Color = "green" }.Draw();

            yield return new Circle() { X = 80, Y = 80, Radius = 60, Color = "blue" }.Draw();


        }
    }
}
