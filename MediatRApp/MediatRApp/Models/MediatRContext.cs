using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediatRApp.Models
{
    public class MediatRContext:DbContext
    {
        public MediatRContext() : base("MediatRContext")
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}