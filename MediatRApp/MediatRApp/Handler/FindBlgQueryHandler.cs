using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;
using MediatRApp.Request;

namespace MediatRApp.Handler
{
    public class FindBlogQueryHandler:IRequestHandler<FindBlogQuery,Blog>
    {
        private readonly MediatRContext _mediatRContext;
        public FindBlogQueryHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }
        public Blog Handle(FindBlogQuery message)
        {
            return _mediatRContext.Blogs.Find(message.Id);
        }
    }
}