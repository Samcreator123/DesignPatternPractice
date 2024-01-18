using DesignPatternExample.Strategy.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Strategy.Before
{
    public class PriceCalculator
    {
        public static string GetPrice(CustomType custom, decimal originPrice) => custom switch
        {
            CustomType.ADULT => $"總共為 {originPrice} 元",
            CustomType.SENIOR => $"總共為 {Math.Round(originPrice * 0.5m)} 元",
            CustomType.CHILD => $"總共為 {Math.Round(originPrice * 0.6m)} 元",
            _ => $"總共為 {originPrice} 元",
        };
    }
}
