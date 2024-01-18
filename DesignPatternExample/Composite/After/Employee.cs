namespace DesignPatternExample.Composite.After
{
    internal class Employee : IComponent
    {
        readonly string _name;
        public string Name { get => "Employee: " + _name; }

        //使用組合模式要注意最底層的
        [Obsolete("組合模式最底層，沒有其他的Component了")]
        public List<IComponent> Components => throw new NotImplementedException();

        public Employee(string name)
        {
            _name = name;
        }
    }
}
