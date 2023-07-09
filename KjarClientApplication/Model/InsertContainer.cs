using Newtonsoft.Json;

namespace com
{
    public class InsertCommand:Command
    {
        [JsonProperty(PropertyName = "insert")]
        public Insert Insert { get; set; }
    }
}