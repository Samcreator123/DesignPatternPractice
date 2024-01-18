using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Strategy.Before
{
    /// <summary>
    /// 若需要新增新的價格計算方式則會破壞 開閉原則.
    /// 當計算方式增多 switch 或 if 會變得很長不易閱讀.
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return PriceCalculator.GetPrice(Share.CustomType.ADULT, 100);
            yield return PriceCalculator.GetPrice(Share.CustomType.SENIOR, 100);
            yield return PriceCalculator.GetPrice(Share.CustomType.ADULT, 100);
            yield return PriceCalculator.GetPrice(Share.CustomType.CHILD, 100);
            yield return PriceCalculator.GetPrice(Share.CustomType.CHILD, 100);
        }
    }
}
