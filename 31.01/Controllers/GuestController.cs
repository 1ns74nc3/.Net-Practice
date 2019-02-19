using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogLogic;
using BlogLogic.Models;

namespace _31._01.Controllers
{
    public class GuestController : Controller
    {
        public ActionResult Guest(Comment comment)
        {
            CommentsManager commentsManager = new CommentsManager();
            ViewBag.Comments = commentsManager.GetData();
            
            //add new comment 
            if (Request.HttpMethod == "POST")
            {
                if (ModelState.IsValid)
                {
                    comment.CommentDate = DateTime.Now;
                    commentsManager.AddItem(comment);
                    ViewBag.Comments = commentsManager.GetData();
                    return View();
                }
                else
                {
                    return View();  
                }
            }
            return View();
        }
    }
}