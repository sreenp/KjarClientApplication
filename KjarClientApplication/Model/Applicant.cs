using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace com
{
    [Serializable]
    public class Applicant
    {
        // Label: age
        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

        // Label: approved
        [JsonProperty(PropertyName = "approved")]
        public bool? Approved { get; set; }

        // Label: money
        [JsonProperty(PropertyName = "money")]
        public double? Money { get; set; }

        // Label: name
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public Applicant() { }

        public Applicant(int? age, bool? approved, double? money, string name)
        {
            this.Age = age;
            this.Approved = approved;
            this.Money = money;
            this.Name = name;
        }
    }
}
