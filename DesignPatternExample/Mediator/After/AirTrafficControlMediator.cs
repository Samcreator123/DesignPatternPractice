namespace DesignPatternExample.Mediator.After
{
    public class AirTrafficControlMediator
    {
        private static AirTrafficControlMediator _singleton;
        private List<IAirplane> airplanes = new List<IAirplane>();

        private AirTrafficControlMediator() { }

        public static AirTrafficControlMediator GetAirTrafficControlMediator() => _singleton ??= new AirTrafficControlMediator();

        public void RegisterAirplane(IAirplane airplane)
        {
            _singleton.airplanes.Add(airplane);
        }

        public IEnumerable<string> Send(string message, IAirplane sender)
        {

            foreach (var reciever in _singleton.airplanes)
            {
                if (reciever.Name == sender.Name)
                {
                    continue;
                }

                yield return reciever.Recieve(message, sender);
            }
        }
        public IEnumerable<string> Send(string message, IAirplane sender, params string[] names)
        {
            List<string> nameList = names == null || names.Count() == 0 ? new List<string>() : names.ToList();
            
            foreach (var reciever in _singleton.airplanes)
            {
                if (reciever.Name == sender.Name)
                {
                    continue;
                }

                if (nameList.Contains(reciever.Name))
                { 
                    yield return reciever.Recieve(message, sender);
                }
            }
        }
    }
}
