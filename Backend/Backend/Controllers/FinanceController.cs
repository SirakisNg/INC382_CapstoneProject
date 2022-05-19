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
            Console.WriteLine("info : " + DateTime.Today + " : Finance access test success ...");
            return "This is a Finance test response";
        }

        public FinanceController(ILogger<FinanceController> logger) => _logger = logger;


        public IActionResult GetAllOrder()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : getAllOrder");
            return View(context.getAllOrder());
        }

        public IActionResult Inventory(string startDate, string endDate)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Inventory infomation");
            return View(context.getInventory(startDate,endDate));
        }
        public IActionResult GeneralLedger()
        {
            return View();
        }

        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult JournalizingTransaction()
        {
            return View();
        }
        public IActionResult MothlyIncomeStatement()
        {
            return View();
        }
        public IActionResult PurchaseOrder()
        {
            return View();
        }

    }
}
