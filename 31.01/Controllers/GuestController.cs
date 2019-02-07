using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogLogic;

namespace _31._01.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Guest(string guestName, string reviewTextBox)
        {
            CommentsManager commentsManager = new CommentsManager();
            var comments = commentsManager.GetData();

            //add new comment 
            if (Request.HttpMethod == "POST")
            {
                commentsManager.AddItem(new Comment { CommentAuthor = guestName, CommentText = reviewTextBox, CommentDate = DateTime.Now });
                comments = commentsManager.GetData();
            }

            return View(comments);
        }
    }
}