namespace FactoryPatternExercise2;

public static class DataFactory
{
    public static IDataAccess GetDataAccess(string dataType)
    {
        switch (dataType.ToLower())
        {
            case "Word":
                return new Word();
            case "Excel":
                return new Excel();
            default:
                return new Word();
        }
    }
}