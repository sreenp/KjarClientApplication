using com;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KjarClientApplication.Model
{
    public class InsertObject
    {
        [JsonProperty(PropertyName = "com.Applicant")]
        public Applicant Applicant { get; set; }
    }
}
