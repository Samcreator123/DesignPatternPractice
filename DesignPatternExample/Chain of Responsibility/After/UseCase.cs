using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Chain_of_Responsibility.After
{
    /// <summary>
    /// 使用責任鏈可以擺脫長長的switch或if，並且達到關注點分離
    /// 但是會有很多類別，且如果每次都到鏈的最後一個節點會很消耗時間
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            var logger = new LoggerHandler();

            yield return logger.WriteLog(0, "hi");
            yield return logger.WriteLog(0, "hi");
            yield return logger.WriteLog(1, "hi");
            yield return logger.WriteLog(3, "hi");
        }
    }
}
