using KjarClientApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace com
{
    public class Insert
    {
        [JsonProperty(PropertyName = "object")]
        public InsertObject Object { get; set; }
        [JsonProperty(PropertyName = "out-identifier")]
        public string OutIdentifier { get; set; } // this can be used to get the object reference in other commands
        [JsonProperty(PropertyName = "return-object")]
        public bool ReturnObject { get; set; } // set this to false if you don't want the inserted object to be in the response
        [JsonProperty(PropertyName = "entry-point")]
        public string EntryPoint { get; set; } // set this to false if you don't want the inserted object to be in the response
        [JsonProperty(PropertyName = "disconnected")]
        public bool Disconnected { get; set; } // set
    }
}
