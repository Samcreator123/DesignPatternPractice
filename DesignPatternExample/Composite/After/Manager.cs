namespace DesignPatternExample.Composite.After
{
    internal class Manager : IComponent
    {
        readonly string _name;
        readonly List<IComponent> _components;

        public string Name { get => "Manager: " + _name; }
        public List<IComponent> Components { get => _components; }

        public Manager(string name, List<IComponent> components)
        {
            _name = name;
            _components = components;
        }
        public static IComponent GetFakeManager()
        {
            List<IComponent> employees = new List<IComponent>() { new Employee("lee"), new Employee("ho"), new Employee("lin") };
            List<IComponent> teams = new List<IComponent>() { new Team("Engineering", employees) };
            List<IComponent> departments = new List<IComponent>() { new Department("Product", teams) };
            IComponent manager = new Manager("Sam", departments);
            return manager;
        }

    }
}
