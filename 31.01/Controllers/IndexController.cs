using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogLogic;
using BlogLogic.Models;

namespace _31._01.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ArticlesManager articlesManager = new ArticlesManager();
            var articles = articlesManager.GetData()
                .Select(item => new Article { ArticleName = item.ArticleName, ArticleText = item.ArticleText })
                .ToList();
            ViewBag.VoteType = "Vote";
            if (Request.HttpMethod == "POST")
            {
                ViewBag.VoteType = "Result";
                VotingManager votesManager = new VotingManager();
                var genderValue = Request.Form["gender"];
                if (genderValue == "Male")
                {
                    votesManager.AddMaleVote();
                }
                else if(genderValue == "Female")
                {
                    votesManager.AddFemaleVote();
                }
                Voting votes = votesManager.GetData();
                ViewBag.Female = votes.Female;
                ViewBag.Male = votes.Male;
                return View(articles);
            }
            return View(articles);
        }
    }
}