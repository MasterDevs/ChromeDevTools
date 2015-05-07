namespace MasterDevs.ChromeDevTools
{
    public interface ICommandFactory
    {
        string GetMethod(long id);

        Command Create<T>();

        Command<T> Create<T>(T parameter);
    }
}