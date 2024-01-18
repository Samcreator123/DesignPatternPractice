namespace DesignPatternExample.Mediator.Before
{
    public interface IAirplane
    {
        public string Name { get; init; }

        public IEnumerable<string> Send(string message, IAirplane reciever);

        public string Recieve(string message, IAirplane sender);
    }
}
