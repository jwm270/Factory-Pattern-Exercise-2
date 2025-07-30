using System.ComponentModel;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What program would you like to run? Word or Excel?");
            var input = Console.ReadLine();
            
            var program = DataFactory.GetDataAccess(input);
            
            program.Add();
        }
    }
}
