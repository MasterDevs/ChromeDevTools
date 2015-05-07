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