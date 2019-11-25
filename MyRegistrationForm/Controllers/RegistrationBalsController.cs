using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyRegistrationForm.Models;
using MyRegistrationForm.Models.Bal;

namespace MyRegistrationForm.Controllers
{
    public class RegistrationBalsController : Controller
    {
        private MyRegistrationFormContext db = new MyRegistrationFormContext();

        // GET: RegistrationBals
        public ActionResult Index()
        {
            return View(db.RegistrationBals.ToList());
        }

        // GET: RegistrationBals/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationBal registrationBal = db.RegistrationBals.Find(id);
            if (registrationBal == null)
            {
                return HttpNotFound();
            }
            return View(registrationBal);
        }

        // GET: RegistrationBals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrationBals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserName,Email,Phoneno,Address,Country")] RegistrationBal registrationBal)
        {
            if (ModelState.IsValid)
            {
                db.RegistrationBals.Add(registrationBal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registrationBal);
        }

        // GET: RegistrationBals/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationBal registrationBal = db.RegistrationBals.Find(id);
            if (registrationBal == null)
            {
                return HttpNotFound();
            }
            return View(registrationBal);
        }

        // POST: RegistrationBals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserName,Email,Phoneno,Address,Country")] RegistrationBal registrationBal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrationBal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registrationBal);
        }

        // GET: RegistrationBals/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationBal registrationBal = db.RegistrationBals.Find(id);
            if (registrationBal == null)
            {
                return HttpNotFound();
            }
            return View(registrationBal);
        }

        // POST: RegistrationBals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RegistrationBal registrationBal = db.RegistrationBals.Find(id);
            db.RegistrationBals.Remove(registrationBal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
