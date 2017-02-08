using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conceptual.Models
{
    public class ArticleCategory
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string UrlSlug { get; set; }


    }
}