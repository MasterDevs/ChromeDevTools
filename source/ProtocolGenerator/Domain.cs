using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Domain : ProtocolItem
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

        [JsonProperty("experimental")]
        public bool IsExperimental { get; set; }

        [JsonProperty("deprecated")]
        public bool IsDeprecated { get; set; }


        public string[] Dependencies { get; set; }

        public Command GetCommand(string name)
        {
            return this.Commands.SingleOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));
        }

        public Type GetType(string name)
        {
            return this.Types.SingleOrDefault(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
