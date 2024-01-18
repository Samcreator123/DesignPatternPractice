namespace DesignPatternExample.Mediator.After
{
    public class Airplane : IAirplane
    {
        AirTrafficControlMediator _mediator;
        public string Name { get; init; }

        public Airplane(string name, AirTrafficControlMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public IEnumerable<string> Send(string message)
        {
            yield return Name + " send message to " + _mediator + " : " + message;

            foreach (string msg in _mediator.Send(message, this))
            {
                yield return msg;
            }  
        }

        public IEnumerable<string> Send(string message, params string[] names)
        {
            yield return Name + " send message to " + _mediator + " : " + message;

            foreach (string msg in _mediator.Send(message, this, names))
            {
                yield return msg;
            }
        }

        public string Recieve(string message, IAirplane sender)
        {
            return Name + " recieve message from " + sender.Name + " : " + message;
        }

    }
}
