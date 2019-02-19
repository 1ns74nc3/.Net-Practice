using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLogic.Models
{
    public class Comment : BlogBase
    {
        public DateTime CommentDate { get; set; }

        [Required]
        public string CommentAuthor { get; set; }

        [Required]
        public string CommentText { get; set; }
    }
}
