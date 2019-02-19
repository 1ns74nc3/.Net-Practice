using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLogic.Models
{
    public class Article : BlogBase
    {
        public DateTime DatePublished { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string ArticleText { get; set; }
        public string ArticleName { get; set; }
        public string Tags { get; set; }
    }
}
