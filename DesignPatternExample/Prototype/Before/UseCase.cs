using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Prototype.Before
{
    //如果每次要複製一樣的都要建立一次
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return new Cake(true, true, true, true).GetIngredient();
            yield return new Cake(true, true, true, true).GetIngredient();
        }
    }
}
