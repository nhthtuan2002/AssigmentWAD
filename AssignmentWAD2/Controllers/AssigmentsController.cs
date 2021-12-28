using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AssignmentWAD2.Data;
using AssignmentWAD2.Models;

namespace AssignmentWAD2.Controllers
{
    public class AssigmentsController : Controller
    {
        private AssignmentWAD2Context db = new AssignmentWAD2Context();

        // GET: Assigments
        public ActionResult Index()
        {
            return View(db.Assigments.ToList());
        }

        // GET: Assigments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assigment assigment = db.Assigments.Find(id);
            if (assigment == null)
            {
                return HttpNotFound();
            }
            return View(assigment);
        }

        // GET: Assigments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assigments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExamSubject,StartTime,ExamDate,ExamDuration,ClassRoom,Faculty,Status")] Assigment assigment)
        {
            if (ModelState.IsValid)
            {
                db.Assigments.Add(assigment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assigment);
        }

        // GET: Assigments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assigment assigment = db.Assigments.Find(id);
            if (assigment == null)
            {
                return HttpNotFound();
            }
            return View(assigment);
        }

        // POST: Assigments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExamSubject,StartTime,ExamDate,ExamDuration,ClassRoom,Faculty,Status")] Assigment assigment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assigment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assigment);
        }

        // GET: Assigments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assigment assigment = db.Assigments.Find(id);
            if (assigment == null)
            {
                return HttpNotFound();
            }
            return View(assigment);
        }

        // POST: Assigments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assigment assigment = db.Assigments.Find(id);
            db.Assigments.Remove(assigment);
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
