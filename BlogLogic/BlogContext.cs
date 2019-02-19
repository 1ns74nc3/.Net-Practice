using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogLogic.Models;

namespace BlogLogic
{
    class BlogContext : DbContext 
    {
        static BlogContext()
        {
            Database.SetInitializer(new BlogContextInitializer());
        }

        public BlogContext() : base("DefaultConnection")
        { }

        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<Article> Articles { get; set; }
        public IDbSet<Voting> Voting { get; set; }
    }
}
