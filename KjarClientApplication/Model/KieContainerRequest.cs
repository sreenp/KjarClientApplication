using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace com
{
    public class KieContainerRequest
    {
        [JsonProperty(PropertyName = "lookup")]
        public string Lookup { get; set; } // this can be used to specify the KIE session
        [JsonProperty(PropertyName = "commands")]
        public List<Command> Commands { get; set; }
    }
}
