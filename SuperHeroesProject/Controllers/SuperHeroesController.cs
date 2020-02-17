using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesProject.Data;
using SuperHeroesProject.Models;

namespace SuperHeroesProject.Controllers
{
    public class SuperHeroesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SuperHeroesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: SuperHeroes
        public ActionResult Index()
        {
            return View(_context.Heroes);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int Id)
        {
            var heroDetailsOnDb = _context.Heroes.FirstOrDefault(x => x.Id == Id);
            return View(heroDetailsOnDb);
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("name, alterEgo, primeAbility, secondAbility, catchphrase")] Hero hero)
        {
            try
            {
                _context.Heroes.Add(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(hero);
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero)
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

        // GET: SuperHeroes/Delete/5
       

        // POST: SuperHeroes/Delete/5
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int Id)
        {
            try
            {
                var deletHeroOnDb = _context.Heroes.FirstOrDefault(x => x.Id == Id);
                _context.Remove(deletHeroOnDb);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}