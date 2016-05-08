namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class Version
    {
        public string Major
        {
            get;
            set;
        }

        public string Minor
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{this.Major}.{this.Minor}";
        }
    }
}
