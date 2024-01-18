using DesignPatternExample.Prototype.Share;

namespace DesignPatternExample.Prototype.After
{
    //使用原型模式 讓每次複製只要呼叫函數
    public class Cake : ICake
    {
        bool _isAddMango;
        bool _isAddStrawberry;
        bool _isAddBlueberry;
        bool _isAddCherry;

        public Cake()
        {
        }
        //改成生成器 builder模式
        public void AddMango()
        {
            _isAddMango = true;
        }
        public void AddStrawberry()
        {
            _isAddStrawberry = true;
        }
        public void AddBlueberry()
        {
            _isAddBlueberry = true;
        }
        public void AddCherry()
        {
            _isAddCherry = true;
        }

        //使用原型模式 讓每次複製只要呼叫函數
        public T? Copy<T>() where T : class
        {
            Cake cake = new ();
            // 要注意如果要深複製則址類型的資料要注意
            if (this._isAddCherry) cake.AddCherry();
            if (this._isAddBlueberry) cake.AddBlueberry();
            if (this._isAddMango) cake.AddMango();
            if (this._isAddStrawberry) cake.AddStrawberry();
            return cake as T;
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
