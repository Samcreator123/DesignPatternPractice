using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Facade.Example
{
    /// <summary>
    /// 利用 Facade 將一系列複雜、牽扯到多個物件的邏輯包裝起來
    /// 使得客戶端方便使用
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            DinerFacade dinerFacade = new DinerFacade();

            foreach (var item in dinerFacade.Order()) 
            {
                yield return item;
            }

            yield return "食用完畢";

            foreach (var item in dinerFacade.PayForMeal())
            {
                yield return item;
            }
        }
    }
}
