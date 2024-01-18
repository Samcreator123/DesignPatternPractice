namespace DesignPatternExample.Composite.Before
{
    internal class Team
    {
        readonly string _name;
        readonly List<Employee> _employees;
        public string Name { get => "Team: " + _name; }
        public List<Employee> Employees { get => _employees; }
        public Team(string name, List<Employee> employees)
        {
            _name = name;
            _employees = employees;

        }
    }
}
