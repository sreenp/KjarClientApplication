using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KjarClientApplication.Model
{
    public class KieServerRequest
    {
        [JsonProperty("model-namespace")]
        public string modelnamespace { get; set; }

        [JsonProperty("model-name")]
        public string modelname { get; set; }

        [JsonProperty("dmn-context")]
        public DmnContext dmncontext { get; set; }
    }
}
