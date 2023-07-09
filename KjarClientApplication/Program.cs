using com;
using KjarClientApplication.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
    }
}
