using com;
using com.myspace.triagesample;
using KjarClientApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace KjarClientApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://localhost:8080/kie-server/services/rest/server/containers/instances/Applicant_1.0.0-SNAPSHOT";  // replace with your URL
            var username = "wbadmin";  // replace with your username
            var password = "wbadmin";  // replace with your password

            //  await InvokeDrl(url, username, password);
            // url = "http://localhost:8080/kie-server/services/rest/server/containers/TriageSample_1.0.0-SNAPSHOT/dmn";
            // await InvokeDmn(url, username, password);
            string json = "{your JSON string here}";
            using (StreamReader r = new StreamReader(@"./ExpectedResponses/" + "response" + ".json"))
            {
                json = r.ReadToEnd();
            }

            // Deserialize the JSON string to the RootObject
            var responseObject = JsonConvert.DeserializeObject<RootObject>(json);

            // Access the specific result
            var firstResultEntry = responseObject.result.dmnEvaluationResult.decisionResults.FirstOrDefault();
            var result = firstResultEntry.Value.result;

            // Print the result
            Console.WriteLine("Description: " + result.description);
            Console.WriteLine("Rule ID: " + result.ruleID);
            Console.WriteLine("Workbasket ID: " + result.workbasketID);
        }

        private static async Task InvokeDrl(string url, string username, string password)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}")));

                var kieRequestModel = new KieContainerRequest
                {
                    Lookup = null,
                    Commands = new System.Collections.Generic.List<Command>()
                };
                Applicant applicant = new Applicant
                {
                    Age = 28,
                    Money = 566,
                    Approved = false,
                    Name = "Applicant1"
                };
                var commands = new List<Command>
                {
                     new InsertCommand
                      {
                        Insert = new Insert
                         {
                             Object = new InsertObject
                             {
                                 Applicant = new Applicant
                                 {
                                     Age = 40,
                                     Money = 100,
                                     Approved = false,
                                      Name = "applicant1"
                                  }
                             },
                             OutIdentifier = "Applicant",
                             ReturnObject = true,
                             EntryPoint = "DEFAULT",
                             Disconnected = false
                          }
                      },
                     new FireAllRulesCommand
                     {
                         FireAllRules = new FireAllRules
                          {
                            max = -1,
                            OutIdentifier = "firedActivations"
                          }
                     }
                };

                kieRequestModel.Commands = commands;



                var json = JsonConvert.SerializeObject(kieRequestModel);
                Console.WriteLine("Json Request" + json);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, stringContent);

                var responseString = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseString);
            }
        }
        private static async Task InvokeDmn(string url, string username, string password)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}")));

                var kieRequestModel = new KieServerRequest
                {
                    modelname = "TriageRules",
                    modelnamespace = "https://kiegroup.org/dmn/_C3D4B04D-7FD5-4035-B81D-FD5E924C4C21",
                    dmncontext = new DmnContext
                    {
                        ClaimsTransaction = new com.myspace.triagesample.ClaimsTransaction()
                   }
                };


                kieRequestModel.dmncontext.ClaimsTransaction = GetExpectedResponse<ClaimsTransaction>("claimsTransaction");



                var json = JsonConvert.SerializeObject(kieRequestModel);
                Console.WriteLine("Json Request" + json);
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, stringContent);

                var responseString = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseString);
            }
        }
        public static T GetExpectedResponse<T>(string requestName)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            httpResponseMessage.StatusCode = System.Net.HttpStatusCode.OK;
            var format = new JsonMediaTypeFormatter();
            string jsonText = null;

            using (StreamReader r = new StreamReader(@"./ExpectedResponses/" + requestName + ".json"))
            {
                jsonText = r.ReadToEnd();
            }
            T dataItem = JsonConvert.DeserializeObject<T>(jsonText);
            return dataItem;
        }
    }
}
