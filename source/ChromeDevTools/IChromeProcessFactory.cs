namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(int port, bool headless);
    }
}