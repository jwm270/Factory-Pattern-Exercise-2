namespace FactoryPatternExercise2;

public class Excel : IDataAccess
{
    public void Add()
    {
        Console.WriteLine("Working in Excel.");
    }
}