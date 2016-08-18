using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;
using MediatRApp.Models;

namespace MediatRApp.Request
{
    public class BlogsQuery:IRequest<List<Blog>>
    {
        public string SortOrder { get; set; }
    }
}