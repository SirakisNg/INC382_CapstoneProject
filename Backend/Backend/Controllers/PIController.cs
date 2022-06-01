using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json;


namespace Backend.Controllers
{
    [ApiController]
    [Route("api/pi")]
    public class PIController : ControllerBase
    {
        private readonly string username = "group1";
        private readonly string password = "inc.382";
        private readonly ILogger<PIController> _logger;
        public PIController(ILogger<PIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemValuesAsync(string itemname)
        {
            try
            {
                //business logic
                Console.WriteLine(@$"Connecting to PI..." + itemname + "");
                var credentrials = new NetworkCredential(username, password);
                HttpClientHandler clientHandler = new HttpClientHandler { Credentials = credentrials };
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                HttpClient client = new HttpClient(clientHandler);

                string webId = "";
                string piserverURL = @$"https://202.44.12.146:1443/piwebapi/points/?path=\\PISRV\{itemname}";
                using (HttpResponseMessage response = await client.GetAsync(piserverURL))
                {
                    string content = await response.Content.ReadAsStringAsync();
                    webId = JObject.Parse(content)["WebId"].Value<string>();
                    Console.WriteLine(@$"Connecting to web id ..." + webId + "");
                }

                string itemURL = @$"https://202.44.12.146:1443/piwebapi/streams/" + webId + "/recorded?starttime=*-2y&endtime=*";
                using (HttpResponseMessage response = await client.GetAsync(itemURL))
                {
                    string content = await response.Content.ReadAsStringAsync();

                    var data = (JArray)JObject.Parse(content)["Items"];
                    var result = new List<TagValue>();

                    foreach (var item in data)
                    {
                        if (item["Good"].Value<bool>() == true)
                        {
                            var dataPair = new TagValue()
                            {
                                Values = item["Value"].Value<string>(),
                                TimeStamp = item["Timestamp"].Value<DateTime>()
                            };
                            result.Add(dataPair);
                        }
                    }
                    return Ok(new { result = result, message = "success" });
                }
            }

            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpGet("getDieselVolDaily/{selDate}")]
        public async Task<IActionResult> getDieselVolDailyAsync(DateTime selDate)
        {
            try
            {
                Console.WriteLine(@$"Connecting to PI..." + selDate + "");
                var credentrials = new NetworkCredential("group1", "inc.382");
                HttpClientHandler clientHandler = new HttpClientHandler { Credentials = credentrials };
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyerrors) => { return true; }; // access to https
                HttpClient client = new HttpClient(clientHandler);

                Console.WriteLine("Connecting...");

                DateTime today = DateTime.Now;
                // DateTime month = new DateTime (2022,4,29);
                TimeSpan value = today.Subtract(selDate);
                // TimeSpan value = today.Subtract(month);

                string starttime = Convert.ToString(Convert.ToInt32(value.TotalDays));
                string endtime = Convert.ToString(Convert.ToInt32(value.TotalDays) - 1);
                string itemURL = $@"https://202.44.12.146:1443/piwebapi/streams/F1DP9bkh7eqdMUSKGalDzu9F3wyhUAAAUE1TU1ZcQIAWMSOWMDAWLVMZLURBVEEwMjA/recorded?starttime=*-" + starttime + "d&endtime=*-" + endtime + "d";
                //string itemURL = $@"https://202.44.12.146:1443/piwebapi/streams/F1DP9bkh7eqdMUSKGalDzu9F3wyhUAAAUE1TU1ZcQIAWMSOWMDAWLVMZLURBVEEwMjA/recorded?starttime=*-50d&endtime=*-20d";
                HttpResponseMessage response = await client.GetAsync(itemURL);
                string content = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(content);
                //var data = JsonConvert.DeserializeObject<JArray>(content);
                var data = (JArray)JObject.Parse(content)["Items"];
                //JArray jsonArray = JArray.Parse(content);
                //dynamic data = JObject.Parse(jsonArray[0].ToString());
                //var data = JsonConvert.DeserializeObject<object>(content);


                var result = new List<TagValue>();

                foreach (var item in data)
                {
                    if (item["Good"].Value<bool>() == true)
                    {
                        var dataPair = new TagValue()
                        {
                            Values = item["Value"].Value<string>(),
                            TimeStamp = item["Timestamp"].Value<DateTime>()
                        };
                        result.Add(dataPair);
                    }
                }

                return Ok(new { result = result, message = "success" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }

        }

    }
}