﻿using Microsoft.AspNetCore.Mvc;
using TestFilm.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace TestFilm.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        //public IActionResult Index()
        //{
        //    return Content("Добро пожаловать" + User.Identity.Name);
        //}
        
        private FilmContext db;
        public HomeController(FilmContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Films.ToListAsync());
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Film film)
        {
            film.User = User.Identity.Name;
            db.Films.Add(film);                        
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Film film = await db.Films.FirstOrDefaultAsync(p => p.Id == id);
                if (film != null)
                    return View(film);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Film film)
        {
            film.User = User.Identity.Name;
            db.Films.Update(film);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
