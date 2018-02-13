using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class SuperHeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAllSuperHeroes(string sortOrder)
        {
            IEnumerable<SuperHero> heroes = new DataService().InitializeData();

            switch (sortOrder)
            {
                case "age":
                    heroes = heroes.ToList().OrderBy(hero => hero.Age);
                    break;
                case "universe":
                    heroes = heroes.ToList().OrderBy(hero => hero.Universe);
                    break;
                default:
                    heroes = heroes.ToList().OrderBy(hero => hero.Name);
                    break;
            }
            
            

            return View(heroes);
        }
    }
}