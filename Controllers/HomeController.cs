using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMovieApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static MyMovieApp.Models.PopularMovieModel;

namespace MyMovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var client = new HttpClient();
            var popularURL = "https://api.themoviedb.org/3/movie/popular?api_key=00d191017b7abab337f6023b2a2aba4d&language=en-US&page=1";
            var popularResponse = client.GetStringAsync(popularURL).Result;


            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(popularResponse);

            var response = myDeserializedClass;


            

            return View(response);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
