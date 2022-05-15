
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;







namespace MvcMovie.Controllers
{
    //[ApiController]
    //[Route("api/user")]
    
    public class UserController : Controller
    {

        public string Index()
        {
            return "User page";
        }

        public IActionResult AllUsers()
        {

                DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;

                return View(context.GetAllUsers());

        }




        // //private readonly ILogger<UserController> _logger;
        // private readonly DbContext _databaseContext;
        // public UserController(ILogger<UserController> logger, DbContext databaseContext)
        // {
        //     _logger = logger;

        //     _databaseContext = databaseContext;
        // }
        // [HttpGet]
        // public IActionResult GetUsers()
        // {
        //     // business logic
        //     //return  Ok(new { message = "success" });
        // }
        // [HttpPut]
        // public IActionResult UpdateUser()
        // {
        //     // business logic
        //     return  Ok(new { message = "success" });
        // }
        // [HttpPost]
        // public IActionResult CreateUser()
        // {
        //     // business logic
        //     return  Ok(new { message = "success" });
        // }
        // [HttpDelete]
        // public IActionResult DeleteUser()
        // {
        //     // business logic
        //     return  Ok(new { message = "success" });
        // }
    }
}
