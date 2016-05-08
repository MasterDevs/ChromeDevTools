using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Event : ProtocolItem
    {
        public Collection<Property> Parameters
        {
            get;
            set;
        }

        public Collection<string> Handlers
        {
            get;
            set;
        }

        public bool Deprecated
        {
            get;
            set;
        }
    }
}
