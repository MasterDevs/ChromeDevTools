using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    static class CollectionExtensions
    {
        public static bool CollectionEqual<T>(this ICollection<T> x, ICollection<T> y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            if(x.Count != y.Count)
            {
                return false;
            }

            return x.All(e => y.Contains(e));
        }

        public static int GetCollectionHashCode<T>(this ICollection<T> x)
        {
            int hash = 17;

            unchecked
            {
                foreach (var e in x)
                {
                    hash = hash * 23 + e.GetHashCode();
                }
            }

            return hash;
        }
    }
}
