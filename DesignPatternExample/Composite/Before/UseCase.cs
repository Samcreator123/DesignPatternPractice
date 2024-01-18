namespace DesignPatternExample.Composite.Before
{
    //結構為 Manager => Department => Team => Employee
    //如果結構變了(例如Team => Department) 要改的地方就有
    // 1. 當初組裝結構的地方  Manager.GetFakeManager
    // 2. Manager當中 Department 要變成 Team ， Team 的 Employee 要變成 Department ，Department的 Team 要變成 Employee
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            Manager manager =  Manager.GetFakeManager();

            yield return manager.Name;

            foreach (var department in manager.Departments)
            {
                yield return department.Name;

                foreach (var team in department.Teams)
                {
                    yield return team.Name;

                    foreach (var employee in team.Employees) 
                    {
                        yield return employee.Name;
                    }
                }
            }
        }
        
    }

}
