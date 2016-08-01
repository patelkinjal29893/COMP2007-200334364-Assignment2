using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DesiTadkaRestaurant.Models;

namespace DesiTadkaRestaurant.Controllers
{
    public class MenuTypesController : Controller
    {
        private DesiTadka db = new DesiTadka();

        // GET: MenuTypes
        public ActionResult Index()
        {
            List<MenuType> types = db.MenuTypes.ToList();
            return View(types);
            //return View(db.MenuTypes.ToList());
        }

        // GET: MenuTypes/Details/5
        // GET: MenuTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MenuTypeId,Name")] MenuType menuType)
        {
            if (ModelState.IsValid)
            {
                db.MenuTypes.Add(menuType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuType);
        }

        // GET: MenuTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuType menuType = db.MenuTypes.Find(id);
            if (menuType == null)
            {
                return HttpNotFound();
            }
            return View(menuType);
        }

        // POST: MenuTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MenuTypeId,Name")] MenuType menuType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuType);
        }

        // GET: MenuTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuType menuType = db.MenuTypes.Find(id);
            if (menuType == null)
            {
                return HttpNotFound();
            }
            return View(menuType);
        }

        // POST: MenuTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuType menuType = db.MenuTypes.Find(id);
            db.MenuTypes.Remove(menuType);
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

  
            public ActionResult Browse(string MenuType)
            {
                MenuType MenuTypeModel = db.MenuTypes.Include("MenuItems").Single(g => g.Name == MenuType);
                return View(MenuTypeModel);
            }
            public ActionResult Details(int id = 1)
            {
                MenuItem MenuItem = db.MenuItems.Find(id);
                return View(MenuItem);
            }
        }
    }

