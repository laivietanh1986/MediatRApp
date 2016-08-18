using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;
using MediatRApp.Request;

namespace MediatRApp.Handler
{
    public class BlogDeleteCommandHandler:IRequestHandler<BlogDeleteCommand,Unit>
    {
        private MediatRContext _mediatRContext;

        public BlogDeleteCommandHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }
        public Unit Handle(BlogDeleteCommand message)
        {
            var blog = _mediatRContext.Blogs.Find(message.BlogId);
            _mediatRContext.Blogs.Remove(blog);
            _mediatRContext.SaveChanges();
            return Unit.Value;
        }
    }
}