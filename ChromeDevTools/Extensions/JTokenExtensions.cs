using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
    public static class JTokenExtensions
    {
        public static string GetSafeString(this JToken jtoken)
        {
            if (null == jtoken) return null;
            return jtoken.ToString();
        }
    }
}
