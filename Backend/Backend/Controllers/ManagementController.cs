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
    public class ManagementController : Controller
    {

        public string Index()
        {
            Console.WriteLine("info : " + DateTime.Today + " : Management access test success ...");
            return "This is an Management test response";
        }
        private readonly ILogger<ManagementController> _logger;

        private DBConnect ConnectDB = new DBConnect();//Database connection

        public ManagementController(ILogger<ManagementController> logger) => _logger = logger;

        public IActionResult Management()
        {
            ManagementContext context = HttpContext.RequestServices.GetService(typeof(Backend.Models.ManagementContext)) as ManagementContext;
            Console.WriteLine("info : " + DateTime.Today + " : Management");
            return View(context.managements());
        }
    }
}
