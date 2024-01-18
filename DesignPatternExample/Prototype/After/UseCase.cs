using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Prototype.After
{
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            Cake cake = new Cake();
            cake.AddCherry();
            cake.AddMango();
            cake.AddBlueberry();
            cake.AddStrawberry();

            yield return cake.GetIngredient();
            yield return cake.Copy<Cake>().GetIngredient();
        }
    }
}
