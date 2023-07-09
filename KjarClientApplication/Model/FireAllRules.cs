using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace com
{
    public class FireAllRules
    {
        [JsonProperty(PropertyName = "out-identifier")]
        public string OutIdentifier { get; set; }

        [JsonProperty(PropertyName = "max")]
        public int max { get; set; }
    }
}
