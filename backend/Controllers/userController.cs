using System;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/user")]

    public class userController : controllerBase
    {
        private readonly ILogger<userController> _logger;

        private readonly DBContext _databaseContext;
        public userController(ILogger<userController> logger, DBContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        [HttpGet]
         public IActionResult GetUsers()
        {
            return ok(new {message = "success"});
    
        }

        [HttpGet]
         public IActionResult UpdateUser()
        {
            return ok(new {message = "success"});
    
        }
        
        [HttpGet]
         public IActionResult CreateUser()
        {
            return ok(new {message = "success"});
    
        }

        [HttpGet]
         public IActionResult DeleteUser()
        {
            return ok(new {message = "success"});
    
        }



    }
}
