using System;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeSessionFactory
    {
        IChromeSession Create(string endpointUrl, Action<Exception> onError);
    }
}