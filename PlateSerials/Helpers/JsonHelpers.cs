using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlateSerials.Helpers
{
    public static class JsonHelpers
    {
        public static string GetJsonValue(this string path, string key)
        {
            string jsonContent = File.ReadAllText(path);

            JsonDocument jsonDoc = JsonDocument.Parse(jsonContent);

            JsonElement root = jsonDoc.RootElement;

            if (root.TryGetProperty(key, out JsonElement value))
            {
                return value.ToString();
            }
            return string.Empty;
        }
    }
}
