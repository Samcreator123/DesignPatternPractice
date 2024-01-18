using DesignPatternExample;

namespace DesignPatternPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUseCase useCase = new DesignPatternExample.Command.After.UseCase();

            foreach (var item in useCase.Print())
            {
                Console.WriteLine(item);
            }
        }
    }
}