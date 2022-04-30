using MvcMovie.Models;
namespace MvcMovie.Models
{
    public class Album
    {
        private MusicStoreContext context;

        public int ID { get; set; }

        public string Name { get; set; }

        public string ArtistName { get; set; }

        public int Price { get; set; }

        public string Genre { get; set; }
    }
}
