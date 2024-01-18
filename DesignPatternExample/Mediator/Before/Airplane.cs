using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Mediator.Before
{
    public class Airplane : IAirplane
    {
        public string Name { get; init; }

        public Airplane(string name)
        {
            Name = name;
        }

        public IEnumerable<string> Send(string message, IAirplane reciever)
        {
            yield return reciever.Recieve(message, this);
            yield return Name + " send message to " + reciever.Name + " : " + message;
        }

        public string Recieve(string message, IAirplane sender)
        {
            return Name + " recieve message from " + sender.Name + " : " + message;
        }

    }
}
