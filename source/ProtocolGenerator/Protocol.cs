using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Protocol
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
    }
}
