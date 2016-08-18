using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;

namespace MediatRApp.Request
{
    public class BlogDeleteCommand:IRequest
    {
        public int BlogId { get; set; }
    }
}