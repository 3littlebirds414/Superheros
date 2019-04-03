using SuperheroCreatorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreatorProject.Controllers
{
    public class SuperherosController : Controller
    {
        ApplicationDbContext context;

        public SuperherosController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superheros
        public ActionResult Index()
        {
            var listOfSuperHeros = context.SuperHeroes.ToList();
            return View(listOfSuperHeros);
        }

        // GET: Superheros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superheros/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheros/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.SuperHeroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheros/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = new Superhero();
            superhero = context.SuperHeroes.Find(id);
            return View(superhero);

        }

        // POST: Superheros/Edit/5
        //[HttpPost]
        //public ActionResult Create([Bind(Include = "Id, Name, AlterEgo, PrimaryAbility, SecondaryAbility, CatchPhrase")]Superhero superhero)
        //{
      
            
        //}

        // GET: Superheros/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                context.SuperHeroes.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
