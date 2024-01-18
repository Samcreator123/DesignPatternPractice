using DesignPatternExample;

namespace DesignPatternPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUseCase useCase = new DesignPatternExample.State.After.UseCase();

            foreach (var item in useCase.Print())
            {
                Console.WriteLine(item);
            }
        }
    }
}