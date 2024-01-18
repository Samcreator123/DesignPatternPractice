using DesignPatternExample.Composite.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Composite.Before
{
    internal class Department
    {
        readonly string _name;
        readonly List<Team> teams;

        public string Name { get => "Department: " + _name; }
        public List<Team> Teams { get => teams; }

        public Department(string name, List<Team> teams)
        {
            _name = name;
            this.teams = teams;
        }
    }

}
