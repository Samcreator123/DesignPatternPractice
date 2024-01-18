using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Composite.Before
{
    internal class Employee
    {
        readonly string _name;
        public string Name { get => "Employee: " + _name; }
        public Employee(string name)
        {
            _name = name;
        }
    }
}
