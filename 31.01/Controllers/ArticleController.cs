using BlogLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _31._01.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Article(int id)
        {
            ArticlesManager articlesManager = new ArticlesManager();
            var articles = articlesManager.GetData();
            ViewBag.Tags = articles[id].Tags.Split(',');
            return View(articles[id]);
        }
    }
}