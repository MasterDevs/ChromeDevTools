using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Property : Type
    {
        [JsonProperty("name")]
        public override string Name
        {
            get;
            set;
        }

        public bool Optional
        {
            get;
            set;
        }

        [JsonProperty("deprecated")]
        public bool IsDeprecated { get; set; }
    }
}
