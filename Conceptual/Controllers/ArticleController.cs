using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conceptual.Models;
using Conceptual.ViewModels;
using PagedList;

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
            var vm = new ArticleListViewModel
            {
                Articles = singlePageModels,
                PagerPartialViewModel=new PagerPartialViewModel { CurrentPage=pageNumber,TotalPage=articles.Count }
            };
            return View(vm);
        }

        // GET: Article Detail
        public ActionResult Detail()
        {
            return View();
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