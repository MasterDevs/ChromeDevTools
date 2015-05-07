namespace MasterDevs.ChromeDevTools
{
    public class ChromeSessionFactory : IChromeSessionFactory
    {
        public IChromeSession Create(string endpointUrl)
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            endpointUrl = endpointUrl.Replace("ws://localhost", "ws://127.0.0.1");
            var methodTypeMap = new MethodTypeMap();
            var commandFactory = new CommandFactory();
            var responseFactory = new CommandResponseFactory(methodTypeMap, commandFactory);
            var eventFactory = new EventFactory(methodTypeMap);
            var session = new ChromeSession(endpointUrl, commandFactory, responseFactory, eventFactory);
            return session;
        }
    }
}