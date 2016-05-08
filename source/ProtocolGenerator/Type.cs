using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Type : ProtocolItem
    {
        [JsonProperty(PropertyName = "Id")]
        public override string Name
        {
            get;
            set;
        }

        [JsonProperty(PropertyName ="type")]
        public string Kind
        {
            get;
            set;
        }

        public Collection<string> Enum
        {
            get;
            set;
        }

        public Collection<Property> Properties
        {
            get;
            set;
        }

        public Type Items
        {
            get;
            set;
        }

        public int MinItems
        {
            get;
            set;
        }

        public int MaxItems
        {
            get;
            set;
        }

        [JsonProperty("$ref")]
        public string TypeReference
        {
            get;
            set;
        }
    }
}
