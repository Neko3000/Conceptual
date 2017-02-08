using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Conceptual.Models
{
    public class Article
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string CoverImgUrl { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string Content { get; set; }
        public virtual string UrlSlug { get; set; }
        public virtual DateTime PostTime { get; set; }
        public virtual DateTime? ModifyTime { get; set; }

        public virtual int CategoryId { get; set; }
        public virtual ArticleCategory Category { get; set; }
    }
}