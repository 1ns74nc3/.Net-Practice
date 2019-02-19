using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogLogic.Models;

namespace BlogLogic
{
    class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
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
                    ArticleName = "Dolor",
                    AuthorFirstName="Garry",
                    AuthorLastName="Oldman",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Tags = "Lorem,ipsum,dolor"
                },
                new Article
                {
                    DatePublished=DateTime.Parse("2018-07-03"),
                    ArticleName = "Ipsum",
                    AuthorFirstName="John",
                    AuthorLastName="Reevez",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Tags = "sit,amet,consectetur"
                },
                new Article
                {
                    DatePublished=DateTime.Parse("2018-07-04"),
                    ArticleName = "Lorem",
                    AuthorFirstName="Mike",
                    AuthorLastName="Chapman",
                    ArticleText="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer maximus iaculis blandit.Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Tags = "adipiscing,elit,Integer" 
                }
            };

            articles.ForEach(art => context.Articles.Add(art));

            var vote = new Voting
            {
                Female = 45,
                Male = 105
            };

            context.Voting.Add(vote);
            context.SaveChanges();
        }
    }
}
