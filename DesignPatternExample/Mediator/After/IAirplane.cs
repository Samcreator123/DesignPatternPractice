namespace DesignPatternExample.Mediator.After
{
    public interface IAirplane
    {
        public string Name { get; init; }

        public IEnumerable<string> Send(string message);

        public IEnumerable<string> Send(string message, params string[] names);

        public string Recieve(string message, IAirplane sender);
    }
}
