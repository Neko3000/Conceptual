using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Conceptual.ViewModels
{
    public class ArticleCategoryManageEditViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "UrlSlug")]
        public string UrlSlug { get; set; }
    }
    public class ArticleCategoryManageCreateViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "UrlSlug")]
        public string UrlSlug { get; set; }
    }
}