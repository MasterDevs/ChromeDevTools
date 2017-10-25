using System.Collections.ObjectModel;
using System.Linq;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Protocol
    {
        public Collection<string> Compatible { get; set; } = new Collection<string>();

        public Version Version { get; set; }

        public Collection<Domain> Domains { get; set; } = new Collection<Domain>();

        public string[] SourceFiles { get; set; }

        public string Alias { get; set; }

        public Domain GetDomain(string name)
        {
            return Domains.SingleOrDefault(d => string.Equals(d.Name, name, System.StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            if (SourceFiles?.Any() == true)
                return $"{Alias} ({string.Join(", ", SourceFiles)})";

            return Alias;
        }
    }
}
