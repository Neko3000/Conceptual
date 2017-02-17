using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conceptual.Models;
using System.ComponentModel.DataAnnotations;

namespace Conceptual.ViewModels
{
    public class ArticleListViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public PagerPartialViewModel PagerPartialViewModel { get; set; }
    }
    public class PagerPartialViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalPage{ get; set; }
    }
}