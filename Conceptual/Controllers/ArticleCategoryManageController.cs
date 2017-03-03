using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Conceptual.Models;
using Conceptual.ViewModels;

namespace Conceptual.Controllers
{
    public class ArticleCategoryManageController : Controller
    {
        private ConceptualDbContext db = new ConceptualDbContext();

        // GET: ArticleCategoryManage
        public ActionResult Index()
        {
            return View(db.ArticleCategories.ToList());
        }

        // GET: ArticleCategoryManage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = db.ArticleCategories.Find(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }
            return View(articleCategory);
        }

        // GET: ArticleCategoryManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleCategoryManage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleCategoryManageCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var articleCategory = new ArticleCategory
                {
                    Name=model.Name,
                    Description=model.Description,
                    UrlSlug=model.UrlSlug
                };
                db.ArticleCategories.Add(articleCategory);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: ArticleCategoryManage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = db.ArticleCategories.Find(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }

            var vm = new ArticleCategoryManageEditViewModel
            {
                Name=articleCategory.Name,
                Description=articleCategory.Description,
                UrlSlug=articleCategory.UrlSlug
            };
            return View(vm);
        }

        // POST: ArticleCategoryManage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleCategoryManageEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var articleCategory = db.ArticleCategories.Find(model.Id);

                articleCategory.Name = model.Name;
                articleCategory.Description = model.Description;
                articleCategory.UrlSlug = model.UrlSlug;

                db.Entry(articleCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ArticleCategoryManage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleCategory articleCategory = db.ArticleCategories.Find(id);
            if (articleCategory == null)
            {
                return HttpNotFound();
            }
            return View(articleCategory);
        }

        // POST: ArticleCategoryManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArticleCategory articleCategory = db.ArticleCategories.Find(id);
            db.ArticleCategories.Remove(articleCategory);
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
