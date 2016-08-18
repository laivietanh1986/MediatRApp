using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;

namespace MediatRApp.Request
{
    public class FindBlogQuery:IRequest<Blog>
    {
        public int Id { get; set; }
    }
}