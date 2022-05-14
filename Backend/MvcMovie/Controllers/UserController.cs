
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
        //[HttpGet]

        public string Test()
        {
            return "User controller";
        }

        public IActionResult AllUsers()
        {

                DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;

                return View(context.GetAllUsers());

        }

        private readonly ILogger<UserController> _logger;

        private UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        //private readonly ILogger<UserController> _logger;
        private readonly DbContext _databaseContext;

        public UserController(ILogger<UserController> logger, DbContext databaseContext)
        {
            _logger = logger;

            _databaseContext = databaseContext;
        }


        // Get all user
        [HttpGet]
        public IActionResult GetUsers()
        {
            Console.WriteLine("info : " + DateTime.Today + " : Get user");
            try
            {
                var userAll = _databaseContext.Users.ToList(); //Link to DB connect
                return Ok(new { result = userAll, message = "success" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }


        //[HttpPut]
        //public IActionResult UpdateUser()
        //{
        //    Console.WriteLine("info : " + DateTime.Today + " : Update user");
        //    try
        //    {
        //        var _user = _databaseContext.user.SingleOrDefault(o => o.Id
        //        == user.Id);
    
        //        if (_user != null)
        //        {
        //            _user.Password = user.Password;
        //        }
        //        _databaseContext.SaveChanges();
        //        return Ok(new { message = "success" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return  StatusCode(500, new {  message = ex.Message});
        //    }
        //}

        [HttpPost]
        public IActionResult CreateUser()
        {
            // business logic
            return Ok(new { message = "success" });
        }

        [HttpDelete]
        public IActionResult DeleteUser()
        {
            // business logic
            return Ok(new { message = "success" });
        }
    }
}
