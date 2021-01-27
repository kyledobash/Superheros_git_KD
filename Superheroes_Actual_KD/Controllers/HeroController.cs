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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
