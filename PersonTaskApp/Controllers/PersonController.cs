using PersonTaskApp.Context;
using PersonTaskApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PersonTaskApp.Controllers
{
    public class PersonController : Controller
    {
        private PersonContext db = new PersonContext();

        // GET: Person
        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }

        // GET: Person/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Person person = db.Persons.Find(id);

            if (person == null)
                return HttpNotFound();

            return View(person);
        }

        // GET: Person/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Persons.Add(person);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Person person = db.Persons.Find(id);

            if (person == null)
                return HttpNotFound();

            return View(person);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(person);
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Person person = db.Persons.Find(id);

            if (person == null)
                return HttpNotFound();

            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Person p)
        {
            try
            {
                Person person = new Person();

                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    person = db.Persons.Find(id);
                    if (person == null)
                        return HttpNotFound();

                    db.Persons.Remove(person);

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(person);

            }
            catch
            {
                return View();
            }
        }
    }
}
