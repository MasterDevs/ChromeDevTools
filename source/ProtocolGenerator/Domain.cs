using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Domain : ProtocolItem
    {
        public Domain()
        {
            this.Types = new Collection<Type>();
            this.Events = new Collection<Event>();
            this.Commands = new Collection<Command>();
        }

        [JsonProperty(PropertyName = "domain")]
        public override string Name
        {
            get;
            set;
        }

        public Collection<Type> Types
        {
            get;
            set;
        }

        public Collection<Command> Commands
        {
            get;
            set;
        }

        public Collection<Event> Events
        {
            get;
            set;
        }

        public string Availability
        {
            get;
            set;
        }

        public string FeatureGuard
        {
            get;
            set;
        }
    }
}
