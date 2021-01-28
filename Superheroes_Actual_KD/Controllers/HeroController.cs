using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Superheroes_Actual_KD.Models;
using Superheroes_Actual_KD.Data;

namespace Superheroes_Actual_KD.Controllers
{
    public class HeroController : Controller
    {
        public ApplicationDbContext _context;

        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Superhero> superheroes = _context.Superheroes.ToList();

            return View(superheroes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Superhero superhero)
        {
            _context.Superheroes.Add(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var hero = _context.Superheroes.Find(id);
            return View(hero);
        }

        [HttpPost]
        public IActionResult Details(Superhero superhero)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {           
            var hero = _context.Superheroes.Find(id);
            return View(hero);
        }

        [HttpPost]
        public IActionResult Edit(Superhero superhero)
        {
            _context.Superheroes.Update(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var hero = _context.Superheroes.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Superhero superhero)
        {
            _context.Superheroes.Remove(superhero);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
