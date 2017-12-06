using System;
using System.Collections.ObjectModel;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    public abstract class ProtocolItem
    {
        public ProtocolItem()
        {
            this.SupportedBy = new Collection<string>();
        }

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

        public Collection<string> SupportedBy
        {
            get;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public static bool Equals(ProtocolItem a, ProtocolItem b)
        {
            if (a == null && b == null)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            if (a.GetType() != b.GetType())
            {
                return false;
            }

            return a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            // In the Equals method, we only include properties which would impact how 
            // messages are serialized over the wire. E.g.: because the description does not
            // impact this, but the name does, the description is ignored but the name is included.
            var other = obj as ProtocolItem;

            if (other == null)
            {
                return false;
            }

            return string.Equals(other.Name, this.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                if (this.Name != null)
                {
                    hash = hash * 23 + StringComparer.OrdinalIgnoreCase.GetHashCode(this.Name);
                }

                return hash;
            }
        }
    }
}
