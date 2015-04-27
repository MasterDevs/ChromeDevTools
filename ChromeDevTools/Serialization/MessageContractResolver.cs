using Newtonsoft.Json.Serialization;
using System;

namespace ChromeDevTools.Serialization
{
    internal class MessageContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            if (String.IsNullOrEmpty(propertyName))
            {
                return propertyName;
            }
            if (1 == propertyName.Length)
            {
                return Char.ToLowerInvariant(propertyName[0]).ToString();
            }
            return Char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);
        }
    }
}