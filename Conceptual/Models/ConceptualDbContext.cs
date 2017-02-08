using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Conceptual.Models
{
    public class ConceptualDbContext:DbContext
    {
        public ConceptualDbContext() : base("name=ConceptualDbContextConnection")
        {
        }

        public DbSet<Conceptual.Models.Article> Articles { get; set; }
        public DbSet<Conceptual.Models.ArticleCategory> ArticleCategories { get; set; }
    }
}