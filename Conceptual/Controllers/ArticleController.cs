using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conceptual.Models;
using Conceptual.ViewModels;
using PagedList;
using System.Net;

namespace Conceptual.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article List
        private ConceptualDbContext db = new ConceptualDbContext();

        public ActionResult Index(int? page)
        {
            var articles = db.Articles.ToList();

            var pageSize = 12;
            var pageNumber = page ?? 1;
            var singlePageModels = articles.ToPagedList(pageNumber, pageSize);
            var totoalPageNumber = articles.Count / pageSize + 1;

            var vm = new ArticleListViewModel
            {
                Articles = singlePageModels,
                PagerPartialViewModel=new PagerPartialViewModel { CurrentPage=pageNumber,TotalPage=totoalPageNumber }
            };
            return View(vm);
        }

        // GET: Article Detail
        public ActionResult Detail(int? id)
        {
            var article = db.Articles.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (article == null)
            {
                return HttpNotFound();
            }
            var vm = new ArticleDetailViewModel
            {
                Id=article.Id,
                Title=article.Title,
                CoverImgUrl=article.CoverImgUrl,
                ShortDescription=article.ShortDescription,
                Content=article.Content,
                UrlSlug=article.UrlSlug,
                PostTime=article.PostTime,
                ModifyTime=article.ModifyTime,

                Category=article.Category
            };
            return View(vm);
        }

        public ActionResult PagerPartialView(int currentPage,int totalPage)
        {
            var vm = new PagerPartialViewModel
            {
                CurrentPage = currentPage,
                TotalPage = totalPage
            };
            return PartialView("_Pager",vm);
        }
    }
}