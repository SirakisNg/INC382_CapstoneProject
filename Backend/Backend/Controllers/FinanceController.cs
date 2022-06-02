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

        // Inventory ----------------------------------------------------------------------------------------------
        public IActionResult InventoryByDate(string startDate, string endDate)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Inventory infomation by date " + startDate + "" + endDate + "");
            return View(context.getInventory(startDate, endDate));
        }
        public IActionResult InventoryByID(int id)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Inventory infomation");
            return View(context.getInventory_id(id));
        }

        //Show all inventory
        public IActionResult Inventory(string GasType, Double Volume, Double Purchase, Double COG)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get all inventory data...");
            //context.addInventory(GasType, Volume, Purchase, COG);
            return View(context.GetAllInventory());
        }

        // General ledger ----------------------------------------------------------------------------------------------
        public IActionResult GeneralLedger()
        {
            return View();
        }
        // Invoice ----------------------------------------------------------------------------------------------
        public IActionResult Invoice()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get invoice infomation");
            return View(context.getInvoive());
        }
        public IActionResult InvoiceByDate(string startDate, string endDate)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Invoice infomation bt date");
            return View(context.getInvoiceByDate(startDate, endDate));
        }

        public IActionResult InvoiceByID(int id)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine($"info : " + DateTime.Today + $" : get Invoice id : " + id + "");
            return View(context.getInvoiveById(id));
        }
        // ----------------------------------------------------------------------------------------------
        public IActionResult JournalizingTransaction()
        {
            return View();
        }
        public IActionResult MothlyIncomeStatement()
        {
            return View();
        }


        // Purchase Order ----------------------------------------------------------------------------------------------
        public IActionResult PurchaseOrder()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Purchase Order infomation");
            return View(context.getPurcahseOrder());
        }

        public IActionResult PurchaseOrderByDate(string startDate, string endDate)
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get Purchase Order infomation");
            return View(context.getPurcahseOrderByDate(startDate, endDate));
        }

        // General ledger ----------------------------------------------------------------------------------------------

        //Account recieveable
        public IActionResult GeneralLaggerAccountRevieveable()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get GLAR");
            return View(context.GetGLAR());
        }

        //Cash
        public IActionResult GeneralLaggerCash()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get GLC");
            return View(context.GetGLC());
        }

        //Account payable
        public IActionResult GeneralLaggerAccountPayable()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get GLAP");
            return View(context.GetGLAP());
        }

        //Inventory
        public IActionResult GeneralLaggerInventory()
        {
            FinanceContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.FinanceContext)) as FinanceContext;
            Console.WriteLine("info : " + DateTime.Today + " : get GLI");
            return View(context.GetGLI());
        }


    }
}
