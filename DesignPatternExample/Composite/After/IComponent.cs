namespace DesignPatternExample.Composite.After
{
    internal interface IComponent
    {
        string Name { get; }

        List<IComponent> Components { get; }
    }
}
