using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Conceptual.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Conceptual.ViewModels
{
    public class ArticleManageEditViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Cover Url")]
        public string CoverImgUrl { get; set; }
        [Display(Name = "Short Descritption")]
        public string ShortDescription { get; set; }
        [AllowHtml]
        [Display(Name = "Content")]
        public string Content { get; set; }
        [Display(Name = "UrlSlug")]
        public string UrlSlug { get; set; }
        [Display(Name = "PostTime")]
        public DateTime PostTime { get; set; }
        [Display(Name = "ModifyTime")]
        public DateTime? ModifyTime { get; set; }

        [Display(Name = "Category")]
        public int ArticleCategoryForArticle { get; set; }
        public IList<ArticleCategory> ArticleCategories { get; set; }
    }

    public class ArticleManageCreateViewModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Cover Url")]
        public string CoverImgUrl { get; set; }
        [Display(Name = "Short Descritption")]
        public string ShortDescription { get; set; }
        [AllowHtml]
        [Display(Name = "Content")]
        public string Content { get; set; }
        [Display(Name = "UrlSlug")]
        public string UrlSlug { get; set; }
        [Display(Name = "PostTime")]
        public DateTime PostTime { get; set; }
        [Display(Name = "ModifyTime")]
        public DateTime? ModifyTime { get; set; }

        [Display(Name = "Category")]
        public int ArticleCategoryForArticle { get; set; }
        public IList<ArticleCategory> ArticleCategories { get; set; }
    }
}