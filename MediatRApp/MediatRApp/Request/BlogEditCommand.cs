using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using MediatR;

namespace MediatRApp.Request
{
    public class BlogEditCommand:IRequest
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }
}