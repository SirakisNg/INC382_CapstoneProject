using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index
        {
            get
            {
                DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;

                return View(context.GetAllAlbums());
            }
        }

        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Albums()
        {

            DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;

            return View(context.GetAllAlbums());

        }

        public IActionResult AlbumsByID(int ID)
        {
            DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;
            Console.WriteLine("info : " + DateTime.Today + " : Search albums by album id");
            return View(context.GetAlbumsByID(ID));
        }

        public ActionResult deleteAlbum(int deleteID)
        {
            DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;
            Console.WriteLine("info : " + DateTime.Today + " : delete album id " + deleteID + "--->");
            context.deleteAlbum(deleteID);
            return View();
        }

        public ActionResult addAlbum(string name, string artist, int price, string genre)
        {
            DbContext context = HttpContext.RequestServices.GetService(typeof(MvcMovie.Models.DbContext)) as DbContext;
            Console.WriteLine("info : " + DateTime.Today + " : add album id " + "--->");
            context.addAlbum(name, artist, price, genre);
            return View();
        }



    }
}
