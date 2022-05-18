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
    public class FinanceController : Controller
    {
        private readonly ILogger<FinanceController> _logger;

        public string Index()
        {
            Console.WriteLine("info : " + DateTime.Today + " : test");
            return "This is a test page";
        }

        public FinanceController(ILogger<FinanceController> logger) => _logger = logger;


        public IActionResult GetAllOrder()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : getAllOrder");
            //Console.WriteLine(context.getAllOrder.ToString())
            return View(context.getAllOrder());
        }
    }
}
