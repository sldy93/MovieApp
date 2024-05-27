using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using System.Diagnostics;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        MovieDbContext db;

        public HomeController(MovieDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View("Index", db.Movies
                .OrderBy(m => m.Name)
                .ToList());
        }

        public IActionResult Edit(int movieid)
        {
            Movie movie = db.Movies.Where(m => m.MovieId == movieid).FirstOrDefault();
            return View(movie);
        }

        public IActionResult Add()
        {
            return View("Edit", new Movie());
        }

        public IActionResult Save(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                {
                    db.Movies.Add(movie);
                }
                else
                {

                    Movie m = db.Movies.Where(m => m.MovieId == movie.MovieId).FirstOrDefault();
                    if (m != null)
                    {
                        m.Name = movie.Name;
                        m.Year = movie.Year;
                        m.Rating = movie.Rating;
                        m.Genre = movie.Genre;

                    }
                }
                db.SaveChanges();   //Applys to both the edit and add
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", movie);
            }
        }

        public IActionResult Delete(int mid)
        {
            Movie m = db.Movies.Find(mid);
            //Product p = db.Products.FirstOrDefault(pr => pr.ProductId == pid);
            db.Movies.Remove(m);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
