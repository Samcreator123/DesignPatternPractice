namespace DesignPatternExample.Iterator.Example
{
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return "還沒做";
        }
    }
}
