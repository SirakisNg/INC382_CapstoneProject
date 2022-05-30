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
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get average cycle time");
            context.AverageCycleTime();
            return View();
        }
    }
}
