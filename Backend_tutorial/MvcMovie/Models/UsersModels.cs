using MvcMovie.Models;
namespace MvcMovie.Models
{
    public class UserModels
    {
        private DbContext context;

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Password { get; set; }
    }
}
