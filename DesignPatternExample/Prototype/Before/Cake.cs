using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Prototype.Before
{
    public class Cake
    {
        bool _isAddMango;
        bool _isAddStrawberry;
        bool _isAddBlueberry;
        bool _isAddCherry;

        public Cake(bool isAddMango, bool isAddStrawberry, bool isAddBlueberry, bool isAddCherry)
        {
            _isAddMango = isAddMango;
            _isAddStrawberry = isAddStrawberry;
            _isAddBlueberry = isAddBlueberry;
            _isAddCherry = isAddCherry;
        }

        public string GetIngredient()
        {
            string ingredient = string.Empty;
            if (_isAddBlueberry) ingredient += "Blueberry,";
            if (_isAddMango) ingredient += "Mango,";
            if (_isAddStrawberry) ingredient += "Strawberry,";
            if (_isAddCherry) ingredient += "Cherry";
            return ingredient;
        }
    }
}
