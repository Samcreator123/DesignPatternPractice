using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Composite.Before
{
    internal class Manager
    {
        readonly string _name;
        readonly List<Department> _departments;

        public string Name { get => "Manager: " + _name; }
        public List<Department> Departments { get => _departments; }

        public Manager(string name, List<Department> departments)
        {
            _name = name;
            _departments = departments;
        }
        public static Manager GetFakeManager()
        {
            List<Employee> employees = new List<Employee>() { new Employee("lee"), new Employee("ho"), new Employee("lin") };
            List<Team> teams = new List<Team>() { new Team("Engineering", employees) };
            List<Department> departments = new List<Department>() { new Department("Product", teams) };
            Manager manager = new Manager("Sam", departments);
            return manager;
        }
    }
}
