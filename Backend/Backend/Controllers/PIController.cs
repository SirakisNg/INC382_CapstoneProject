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
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Backend.Utill;
using System.Data;


namespace Backend.Controllers
{
    //[ApiController]
    [Route("api/pi")]

    public class PiController : Controller
    {

        [HttpGet("test")]
        public string Get()
        {
            return "hi";
        }

        [HttpGet("getDieselVolDaily/{selDate}")]
        public async Task<IActionResult> getDieselVolDaily(DateTime selDate)
        {
            try
            {
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
                HttpResponseMessage response = await client.GetAsync(itemURL);
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

            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }

        }

    }
}

