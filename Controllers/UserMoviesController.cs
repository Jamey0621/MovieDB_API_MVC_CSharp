using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMovieApp.Data;
using MyMovieApp.Models;

namespace MyMovieApp.Controllers
{
    public class UserMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserMoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserMovies
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserMovie.ToListAsync());
        }

        // GET: UserMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie
                .FirstOrDefaultAsync(m => m.id == id);
            if (userMovie == null)
            {
                return NotFound();
            }

            return View(userMovie);
        }

        // GET: UserMovies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,backdrop_path,movie_id,poster_path,title")] UserMovie userMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userMovie);
        }

        // GET: UserMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie.FindAsync(id);
            if (userMovie == null)
            {
                return NotFound();
            }
            return View(userMovie);
        }

        // POST: UserMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,backdrop_path,movie_id,poster_path,title")] UserMovie userMovie)
        {
            if (id != userMovie.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMovieExists(userMovie.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userMovie);
        }

        // GET: UserMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMovie = await _context.UserMovie
                .FirstOrDefaultAsync(m => m.id == id);
            if (userMovie == null)
            {
                return NotFound();
            }

            return View(userMovie);
        }

        // POST: UserMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userMovie = await _context.UserMovie.FindAsync(id);
            _context.UserMovie.Remove(userMovie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMovieExists(int id)
        {
            return _context.UserMovie.Any(e => e.id == id);
        }
    }
}
