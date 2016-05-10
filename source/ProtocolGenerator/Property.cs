using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Property : Type
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
    }
}
