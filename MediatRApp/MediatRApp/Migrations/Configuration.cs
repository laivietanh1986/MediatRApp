using System.Collections.Generic;
using MediatRApp.Models;

namespace MediatRApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MediatRApp.Models.MediatRContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MediatRApp.Models.MediatRContext context)
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
            context.Blogs.AddOrUpdate(
                blog => blog.BlogId,
                new Blog
                {
                    BlogId = 1,
                    Name = "Blog 1",
                    Posts = new List<Post>()
                    {
                        new Post() {PostId = 1, Title = "Post1 blog 1", Content = "content of post1 blog 1"},
                        new Post() {PostId = 2, Title = "Post2 blog 1", Content = "content of post2 blog 1"},
                        new Post() {PostId = 3, Title = "Post3 blog 1", Content = "content of post3 blog 1"},
                    }
                });
            context.Blogs.AddOrUpdate(
                blog => blog.BlogId,
                new Blog
                {
                    BlogId = 2,
                    Name = "Blog 2",
                    Posts = new List<Post>()
                    {
                        new Post() {PostId = 1, Title = "Post1 blog 2", Content = "content of post1 blog 2"},
                        new Post() {PostId = 2, Title = "Post2 blog 2", Content = "content of post2 blog 2"},
                        new Post() {PostId = 3, Title = "Post3 blog 2", Content = "content of post3 blog 2"},
                    }
                });
            context.SaveChanges();
        }
    }
}
