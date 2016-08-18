using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;
using MediatRApp.Request;

namespace MediatRApp.Handler
{
    public class BlogEditCommandHandler:IRequestHandler<BlogEditCommand,Unit>
    {
        private MediatRContext _mediatRContext;

        public BlogEditCommandHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }
        public Unit Handle(BlogEditCommand message)
        {
            var blog = _mediatRContext.Blogs.Find(message.BlogId);
            blog.Name = message.Name;
            _mediatRContext.SaveChanges();
           return Unit.Value;
        }
    }
}