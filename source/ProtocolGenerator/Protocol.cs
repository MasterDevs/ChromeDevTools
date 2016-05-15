using System.Collections.ObjectModel;
using System.Linq;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public class Protocol
    {
        public Protocol()
        {
            this.Compatible = new Collection<string>();
            this.Domains = new Collection<Domain>();
        }

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

        public string SourceFile
        {
            get;
            set;
        }

        public string Alias
        {
            get;
            set;
        }

        public Domain GetDomain(string name)
        {
            return this.Domains.SingleOrDefault(d => string.Equals(d.Name, name, System.StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            if(this.SourceFile != null)
            {
                return $"{this.Alias} ({this.SourceFile})";
            }
            else
            {
                return this.Alias;
            }
        }
    }
}
