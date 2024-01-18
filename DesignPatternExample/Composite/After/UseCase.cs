using DesignPatternExample.Composite.Before;

namespace DesignPatternExample.Composite.After
{
    //所有都實作同一介面，這樣更改結構時只需要更改 組裝結構的地方  Manager.GetFakeManager
    //但要注意最底層的例外問題
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            IComponent manager = Manager.GetFakeManager();

            foreach (var component in FlattenTree(manager, new List<IComponent>())) 
            {
                yield return component.Name;
            }
        }

        private List<IComponent> FlattenTree(IComponent top,List<IComponent> result)
        {
            result.Add(top);

            //注意底層的例外問題
            if (top is Employee) return result;

            foreach (var component in top.Components) 
            {
                result = FlattenTree(component, result);
            }

            return result;
        }
    }
}
