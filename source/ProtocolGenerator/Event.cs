using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Event : ProtocolItem
    {
        public Event()
        {
            this.Parameters = new Collection<Property>();
            this.Handlers = new Collection<string>();
        }

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
