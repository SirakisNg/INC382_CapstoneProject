using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Backend.Utill;
using System.Data;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Backend.Controllers
{
    public class OperationController : Controller
    {
        private readonly ILogger<FinanceController> _logger;

        public string Index()
        {
            Console.WriteLine("info : " + DateTime.Today + " : Operation access test success ...");
            return "This is an Operation test response";
        }
        public OperationController(ILogger<FinanceController> logger) => _logger = logger;


        public IActionResult Operation()
        {


            Console.WriteLine("info : " + DateTime.Today + " : get average cycle time");

            return View();
        }

        // public IActionResult test()
        // {
        //     FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
        //     DateTime selDate = new DateTime(2022, 03, 26);
        //     //var httpClient = httpClientFactory.CreateClient();
        //     return View(context.getDieselVolDailyAsync(selDate));
        // }
        // public async Tesk<string> Get(string cityName)
        // {
        //     var URL = "https://localhost:5001/api/pi?itemname=A002-0000-S2-DATA10";
        //     var httpClient = new HttpClient();
        //     var response = await await httpClient.GetAsync(URL);
        //     return await response.Content.ReadAsStringAsync();
        // }


        // public IActionResult test(DateTime seldate)
        // {
        //     seldate = new DateTime(2022, 03, 31);
        //     FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
        //     Console.WriteLine("info : " + DateTime.Today + " : get DieselVolDailyAsync");
        //     return View(context.getDieselVolDailyAsync(seldate));
        // }





    }
}
