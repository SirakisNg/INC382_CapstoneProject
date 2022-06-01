using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendDotNet.Models;
using BackendDotNet.Data;
using BackendDotNet.Services;
using BackendDotNet.Services.Interface;

namespace BackendDotNet.Controllers
{
    [ApiController]

    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
        _logger = logger;
        _userService = userService;
        }

        [HttpGet] // https://localhost:7000/api/user
        public IActionResult GetUsers()
        {
            // business logic
            try
            {
                var result = _userService.GetUsers();
                return Ok(new { result = result, message ="success"});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "success" });
            }
        }
        [HttpPut] // https://localhost:7000/api/user
        public IActionResult UpdateUser(User user)
        {
            // business logic
            try
            {
                _userService.UpdateUser(user);
                return Ok(new { message = "success" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            // business logic
            try
            {
                _userService.CreateUser(user);
                return Ok(new { message = "success" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("{id}")] // https://localhost:7000/api/user
        public IActionResult DeleteUser(int id)
        {
            // business logic
            try
            {
                _userService.DeleteUser(id);
                return Ok(new { message = "success" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}

