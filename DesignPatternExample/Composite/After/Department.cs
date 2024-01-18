namespace DesignPatternExample.Composite.After
{
    internal class Department : IComponent
    {
        readonly string _name;
        readonly List<IComponent> _components;

        public string Name { get => "Department: " + _name; }
        public List<IComponent> Components { get => _components; }

        public Department(string name, List<IComponent> components)
        {
            this._name = name;
            this._components = components;
        }
    }
}
