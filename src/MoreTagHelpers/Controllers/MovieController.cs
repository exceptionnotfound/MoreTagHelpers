using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MoreTagHelpers.Managers;
using MoreTagHelpers.Models;
using MoreTagHelpers.ViewModels;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MoreTagHelpers.Views
{
    public class MovieController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View(MovieManager.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddMovieVM newMovie = new AddMovieVM();
            newMovie.AllGenres = new List<SelectListItem>();
            newMovie.AllGenres.Add(new SelectListItem() { Text = "Action", Value = "1" });
            newMovie.AllGenres.Add(new SelectListItem() { Text = "Comedy", Value = "2" });
            newMovie.AllGenres.Add(new SelectListItem() { Text = "Drama", Value = "3" });
            newMovie.AllGenres.Add(new SelectListItem() { Text = "Mystery", Value = "4" });
            return View(newMovie);
        }

        [HttpPost]
        public IActionResult Add(AddMovieVM movie)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
