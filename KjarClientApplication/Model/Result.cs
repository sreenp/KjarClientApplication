using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace KjarClientApplication.Model
{
    public class RootObject
    {
        public Result result { get; set; }
    }

    public class Result
    {
        [JsonProperty("dmn-evaluation-result")]
        public DmnEvaluationResult dmnEvaluationResult { get; set; }
    }

    public class DmnEvaluationResult
    {
        [JsonProperty("decision-results")]
        public Dictionary<string, DecisionResult> decisionResults { get; set; }
    }

    public class DecisionResult
    {
        public string decisionId { get; set; }
        public string decisionName { get; set; }
        public DecisionResultDetails result { get; set; }
    }

    public class DecisionResultDetails
    {
        public string description { get; set; }
        public string ruleID { get; set; }
        public string workbasketID { get; set; }
    }
}
