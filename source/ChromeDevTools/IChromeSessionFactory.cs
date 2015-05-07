namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSessionFactory
    {
        IChromeSession Create(string endpointUrl);
    }
}