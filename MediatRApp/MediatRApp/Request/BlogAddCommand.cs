using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;

namespace MediatRApp.Request
{
    public class BlogAddCommand:IRequest
    {
        public int BlogId  { get; set; }
        public string Name { get; set; }
    }
}