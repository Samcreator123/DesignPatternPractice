using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Mediator.Before
{
    /// <summary>
    /// 數量增加，一架飛機要跟多個飛機通信複雜度會急遽的增加，也不利維護
    /// 發送者與接收者的耦合性也過大
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            var airPlane1 = new Airplane("airPlane1");
            var airPlane2 = new Airplane("airPlane2");
            var airPlane3 = new Airplane("airPlane3");

            foreach (var msg in airPlane1.Send("hi airplane2", airPlane2))
            {
                yield return msg;
            }
            foreach (var msg in airPlane1.Send("hi airplane3", airPlane3))
            {
                yield return msg;
            }
            foreach (var msg in airPlane2.Send("hi airplane1", airPlane1))
            {
                yield return msg;
            }
            foreach (var msg in airPlane3.Send("hi airplane1", airPlane1))
            {
                yield return msg;
            }
        }
    }
}
