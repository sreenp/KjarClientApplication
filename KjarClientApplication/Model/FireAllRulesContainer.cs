using Newtonsoft.Json;

namespace com
{
    public class FireAllRulesCommand:Command
    {
        [JsonProperty(PropertyName = "fire-all-rules")]
        public FireAllRules FireAllRules { get; set; }
    }
}