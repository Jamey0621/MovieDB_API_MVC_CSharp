using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MyMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static MyMovieApp.Models.PopularMovieModel;
using Microsoft.AspNetCore.Authorization;
using MyMovieApp.Data;
using Microsoft.EntityFrameworkCore;

namespace MyMovieApp.Controllers
{
    public class Movie : Controller

    {
        private readonly ApplicationDbContext _context;
        public Movie(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> UserMovieList()
        {
            return View(await _context.UserMovie.ToListAsync());
        }

        [Authorize]
        public ActionResult Index()
        {
            var client = new HttpClient();
            var upComingURL = "https://api.themoviedb.org/3/movie/upcoming?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US&page=1";
            var upComingResponse = client.GetStringAsync(upComingURL).Result;

            UpComing.Root myDeserializedClass = JsonConvert.DeserializeObject<UpComing.Root>(upComingResponse);

            var response = myDeserializedClass;
            return View(response); 
        }
        [Authorize]
        //GET: Movie/similar
        public ActionResult SimilarMovie(int id)
        {
            var client = new HttpClient();
            var simURL = $"https://api.themoviedb.org/3/movie/{id}/similar?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US&page=1";
            var simResponse = client.GetStringAsync(simURL).Result;

            SimilarMovie.Root myDeserializedClass = JsonConvert.DeserializeObject<SimilarMovie.Root>(simResponse);

            var response = myDeserializedClass;

            return View(response);
        }
        [Authorize]
        // GET: Movie/Reviews
        public ActionResult Reviews(int id)
        {
            var client = new HttpClient();
            var reviewURL = $"https://api.themoviedb.org/3/movie/{id}/reviews?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US&page=1";
            var reviewResponse = client.GetStringAsync(reviewURL).Result;

            Reviews.Root myDeserializedClass = JsonConvert.DeserializeObject<Reviews.Root>(reviewResponse);

            var response = myDeserializedClass;
            return View(response);
        }
        public ActionResult AddMovieToList(int id, string title, string poster)
        {

            return View();
        }
        [Authorize]
        // GET: Movie/popularMovie
        public ActionResult PopularMovie()
        {
            var client = new HttpClient();
            var popularURL = "https://api.themoviedb.org/3/movie/popular?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US&page=1";
            var popularResponse = client.GetStringAsync(popularURL).Result;


            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(popularResponse);

            var response = myDeserializedClass;


            return View(response);
        }
        [Authorize]
        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            var client = new HttpClient();
            var movieURL = $"https://api.themoviedb.org/3/movie/{id}?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US";
            var movieResponse = client.GetStringAsync(movieURL).Result;
            MovieModel.Movie.Root myDeserializedClass = JsonConvert.DeserializeObject<MovieModel.Movie.Root>(movieResponse);

            MovieModel.Movie.Root movie = new MovieModel.Movie.Root();
            movie.id = myDeserializedClass.id;
            movie.title = myDeserializedClass.title;
            movie.overview = myDeserializedClass.overview;
            movie.popularity = myDeserializedClass.popularity;
            movie.release_date = myDeserializedClass.release_date;
            movie.runtime = myDeserializedClass.runtime;
            movie.adult = myDeserializedClass.adult;
            movie.backdrop_path = myDeserializedClass.backdrop_path;
            movie.belongs_to_collection = myDeserializedClass.belongs_to_collection;
            movie.budget = myDeserializedClass.budget;
            movie.genres = myDeserializedClass.genres;
            movie.homepage = myDeserializedClass.homepage;
            movie.poster_path = myDeserializedClass.poster_path;
            movie.video = myDeserializedClass.video;
            movie.vote_average = myDeserializedClass.vote_average;
            movie.vote_count = myDeserializedClass.vote_count;

            return View(movie);
        }
        [Authorize]
        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [Authorize]
        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [Authorize]
        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        [Authorize]
        // POST: Movie/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
