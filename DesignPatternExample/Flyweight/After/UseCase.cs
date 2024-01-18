using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Flyweight.After
{
    /// <summary>
    /// 將圓形的顏色的共享，其他做入參，最小化內存消耗
    /// 在這個情況中只要取得相同顏色的圓都是取得同一個位置的
    /// 但要注意多緒問題
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return CircleFactory.GetCircle("red").Draw(x: 5, y : 5, radius : 60);

            yield return CircleFactory.GetCircle("blue").Draw(x: 6, y: 50, radius: 60);

            yield return CircleFactory.GetCircle("green").Draw(x: 7, y: 80, radius: 60);

            yield return CircleFactory.GetCircle("green").Draw(x: 70, y: 80, radius: 60);

            yield return CircleFactory.GetCircle("blue").Draw(x: 80, y: 80, radius: 60);

        }
    }
}
