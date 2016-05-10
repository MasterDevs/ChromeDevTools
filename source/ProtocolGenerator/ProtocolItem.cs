namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    abstract class ProtocolItem
    {
        public virtual string Description
        {
            get;
            set;
        }

        public virtual bool Hidden
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
