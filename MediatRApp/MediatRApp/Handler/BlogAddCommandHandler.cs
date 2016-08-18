using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;
using MediatRApp.Request;

namespace MediatRApp.Handler
{
    public class BlogAddCommandHandler:IRequestHandler<BlogAddCommand,Unit>
    {
        private MediatRContext _mediatRContext;

        public BlogAddCommandHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }
        public Unit Handle(BlogAddCommand message)
        {
            _mediatRContext.Blogs.Add(new Blog()
            {
                BlogId = message.BlogId,
                Name = message.Name
            });
            _mediatRContext.SaveChanges();
            return Unit.Value;
        }
    }
}