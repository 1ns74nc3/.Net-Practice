using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogLogic.Models;

namespace BlogLogic
{
    public class CommentsManager : IManager<Comment>
    {
        //add item to Comments database
        public void AddItem(Comment item)
        {
            using (BlogContext db = new BlogContext())
            {
                db.Comments.Add(item);
                db.SaveChanges();
            }
        }

        //save list to return data from Comments database
        public IList<Comment> GetData()
        {
            List<Comment> answer = new List<Comment>();
            using (BlogContext db = new BlogContext())
            {
                answer = db.Comments.ToList();
            }
            return answer;
        }
    }
}
