using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Composite.After
{
    internal class Team : IComponent
    {
        readonly string _name;
        readonly List<IComponent> _components;
        public string Name { get => "Team: " + _name; }
        public List<IComponent> Components { get => _components; }
        public Team(string name, List<IComponent> components)
        {
            _name = name;
            _components = components;

        }
    }
}
