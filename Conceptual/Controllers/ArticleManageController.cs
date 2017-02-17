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
    public class ArticleManageController : Controller
    {
        private ConceptualDbContext db = new ConceptualDbContext();

        // GET: ArticleManage
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

        // GET: ArticleManage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: ArticleManage/Create
        public ActionResult Create()
        {
            var vm = new ArticleManageCreateViewModel
            {
                PostTime = DateTime.Now,
                ArticleCategories = db.ArticleCategories.ToList(),
            };
            return View(vm);
        }

        // POST: ArticleManage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleManageCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var article = new Article
                {
                    Title = model.Title,
                    CoverImgUrl = model.CoverImgUrl,
                    ShortDescription = model.ShortDescription,
                    Content = model.Content,
                    UrlSlug = model.UrlSlug,
                    PostTime = model.PostTime,
                    ModifyTime = model.ModifyTime,

                    CategoryId = db.ArticleCategories.Find(model.ArticleCategoryForArticle).Id,
                    Category = db.ArticleCategories.Find(model.ArticleCategoryForArticle)
                };
                db.Articles.Add(article);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: ArticleManage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }

            var vm = new ArticleManageEditViewModel
            {
                Id = article.Id,
                Title = article.Title,
                CoverImgUrl = article.CoverImgUrl,
                ShortDescription = article.ShortDescription,
                Content = article.Content,
                UrlSlug = article.UrlSlug,
                PostTime = article.PostTime,
                ModifyTime = article.ModifyTime ?? DateTime.Now,

                ArticleCategoryForArticle = article.CategoryId,
                ArticleCategories = db.ArticleCategories.ToList(),
            };
            return View(vm);
        }

        // POST: ArticleManage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleManageEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var article = db.Articles.Find(model.Id);

                article.Id = model.Id;
                article.Title = model.Title;
                article.CoverImgUrl = model.CoverImgUrl;
                article.ShortDescription = model.ShortDescription;
                article.Content = model.Content;
                article.UrlSlug = model.UrlSlug;
                article.PostTime = model.PostTime;
                article.ModifyTime = model.ModifyTime;
                article.CategoryId = db.ArticleCategories.Find(model.ArticleCategoryForArticle).Id;
                article.Category = db.ArticleCategories.Find(model.ArticleCategoryForArticle);

                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ArticleManage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: ArticleManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
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
