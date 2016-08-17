using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediatRApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}