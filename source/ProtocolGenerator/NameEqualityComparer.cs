using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class NameEqualityComparer : EqualityComparer<ProtocolItem>
    {
        public static NameEqualityComparer Instance
        { get; } = new NameEqualityComparer();

        public override bool Equals(ProtocolItem x, ProtocolItem y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode(ProtocolItem obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);
        }
    }
}
