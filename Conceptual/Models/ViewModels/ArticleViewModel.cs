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
    public class ArticleDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImgUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string UrlSlug { get; set; }
        public DateTime PostTime { get; set; }
        public DateTime? ModifyTime { get; set; }

        public ArticleCategory Category { get; set; }
    }
    public class PagerPartialViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalPage{ get; set; }
    }
}