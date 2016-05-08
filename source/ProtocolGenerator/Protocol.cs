using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Protocol
    {
        public Collection<string> Compatible
        {
            get;
            set;
        }

        public Version Version
        {
            get;
            set;
        }

        public Collection<Domain> Domains
        {
            get;
            set;
        }
    }
}
