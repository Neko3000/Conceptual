namespace Conceptual.Migrations.ConceptualDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Conceptual.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Conceptual.Models.ConceptualDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Conceptual.Models.ConceptualDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var articleCategories = new List<ArticleCategory>
            {
                new ArticleCategory
                {
                    Name="Tutorial",
                    Description="The articles for learning completed task",
                }
            };
            articleCategories.ForEach(singleArticleCategory => context.ArticleCategories.AddOrUpdate(c => c.Name, singleArticleCategory));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article
                {
                    Title="How to create Motion Graphics with Adobe AfterEffects?",
                    CoverImgUrl="",
                    ShortDescription="The tutorial for learning techniques in Motion Graphics",
                    Content="The first day with the most creative and powerful application",
                    PostTime=DateTime.Now,
                    ModifyTime=DateTime.Now,

                    CategoryId=context.ArticleCategories.Single(c=>c.Name=="Tutorial").Id,
                    Category=context.ArticleCategories.Single(c=>c.Name=="Tutorial")
                }
            };
            articles.ForEach(singleArticle => context.Articles.AddOrUpdate(a => a.Title, singleArticle));
            context.SaveChanges();
        }
    }
}
