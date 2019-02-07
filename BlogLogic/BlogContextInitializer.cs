using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogLogic.Models;

namespace BlogLogic
{
    class BlogContextInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var comments = new List<Comment>
            {
                new Comment
                {
                    CommentDate=DateTime.Parse("2019-07-15"),
                    CommentAuthor="Garry Oldman",
                    CommentText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit."
                },
                new Comment
                {
                    CommentDate=DateTime.Parse("2019-07-10"),
                    CommentAuthor="John Reevez",
                    CommentText="Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new Comment
                {
                    CommentDate=DateTime.Parse("2018-07-01"),
                    CommentAuthor="Mike Chapman",
                    CommentText="Lorem ipsum dolor sit amet."
                }
            };
            comments.ForEach(comm => context.Comments.Add(comm));
            var articles = new List<Article>
            {
                new Article
                {
                    DatePublished=DateTime.Parse("2018-07-02"),
                    AuthorFirstName="Garry",
                    AuthorLastName="Oldman",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                },
                new Article
                {
                    DatePublished=DateTime.Parse("2018-07-03"),
                    AuthorFirstName="John",
                    AuthorLastName="Reevez",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet."
                },
                new Article
                {
                    DatePublished=DateTime.Parse("2018-07-04"),
                    AuthorFirstName="Mike",
                    AuthorLastName="Chapman",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit."
                }
            };
            articles.ForEach(art => context.Articles.Add(art));
            context.SaveChanges();
        }
    }
}
