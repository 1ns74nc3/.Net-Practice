﻿using System.Collections.Generic;
using System.Linq;
using BlogLogic.Models;

namespace BlogLogic
{
    public class ArticlesManager
    {
        //add item to Articles database
        public void AddItem(Article item)
        {
            using (BlogContext db = new BlogContext())
            {
                db.Articles.Add(item);
                db.SaveChanges();
            }
        }

        //save list to return data from Articles database
        public IList<Article> GetData()
        {
            List<Article> answer = new List<Article>();
            using (BlogContext db = new BlogContext())
            {
                answer = db.Articles.ToList();
            }
            return answer;
        }
    }
}
