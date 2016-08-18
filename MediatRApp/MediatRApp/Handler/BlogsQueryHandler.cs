using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;
using MediatRApp.Request;

namespace MediatRApp.Handler
{
    public class BlogsQueryHandler:IRequestHandler<BlogsQuery,List<Blog>>
    {
        private readonly MediatRContext _dbContext;

        public BlogsQueryHandler(MediatRContext mediatRContext)
        {
            _dbContext = mediatRContext;
        }
        public List<Blog> Handle(BlogsQuery message)
        {
            switch (message.SortOrder)
            {
                case "desc":
                    return _dbContext.Blogs.OrderByDescending(blog => blog.BlogId).ToList();
                default:
                    return _dbContext.Blogs.OrderBy(blog => blog.BlogId).ToList();
            }
        }
    }
}