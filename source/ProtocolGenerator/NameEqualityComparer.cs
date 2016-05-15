using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class NameEqualityComparer<T> : EqualityComparer<T>
        where T : ProtocolItem
    {
        public static NameEqualityComparer<T> Instance
        { get; } = new NameEqualityComparer<T>();

        public override bool Equals(T x, T y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);
        }
    }
}
