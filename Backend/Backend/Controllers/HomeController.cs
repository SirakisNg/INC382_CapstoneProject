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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DBConnect ConnectDB = new DBConnect();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(LoginChecker() == true)
            {
                return View();
            }
            else
            {
                return View("Login");
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            DataTable dt = ConnectDB.GetData($"SELECT * FROM test.user WHERE Username ='{username}';");
            if(dt.Rows.Count > 0)
            {
                if(dt.Rows[0]["Password"].ToString() == EncodeString.MD5HashCryptography(password))
                {
                    HttpContext.Session.SetString("Login", "1");
                    Console.WriteLine("Login : " + DateTime.Today + $"User : {username} login to the system");
                    return View("Index");
                }
                else
                {
                    Console.WriteLine($"Login : " + DateTime.Today + $"User : {username} login fail");
                    return View("Login");
                }
            }
            return View();
        }


        private bool LoginChecker()
        {
            bool result = false;
            if(HttpContext.Session.GetString("login") != null)
            {
                if (HttpContext.Session.GetString("login") == "1")
                {
                    result = true;
                }
            }
            return result;
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
