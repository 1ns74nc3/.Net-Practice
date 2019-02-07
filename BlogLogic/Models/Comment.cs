using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLogic.Models
{
    public class Comment : BlogBase
    {
        public DateTime CommentDate { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentText { get; set; }
    }
}
