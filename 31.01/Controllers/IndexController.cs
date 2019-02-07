using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogLogic;

namespace _31._01.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ArticlesManager articlesManager = new ArticlesManager();
            var articles = articlesManager.GetData();
            return View(articles);
        }
    }
}