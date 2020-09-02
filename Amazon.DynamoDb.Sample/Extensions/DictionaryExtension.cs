using System.Collections.Generic;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDb.Sample.Extensions
{
    public static class DictionaryExtension
    {
        public static string GetString(this Dictionary<string, AttributeValue> arg, string key)
        {
            string ret = null;

            bool isExist = arg.TryGetValue(key, out AttributeValue attributeValue);
            if (isExist == true)
            {
                ret = attributeValue.S;
            }

            return ret;
        }

        public static int GetInt(this Dictionary<string, AttributeValue> arg, string key)
        {
            int ret = 0;

            bool isExist = arg.TryGetValue(key, out AttributeValue attributeValue);
            if (isExist == true)
            {
                int.TryParse(attributeValue.N, out ret);
            }

            return ret;
        }
    }
}
