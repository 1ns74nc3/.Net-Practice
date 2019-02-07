using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogLogic;

namespace _31._01.Controllers
{
    public class UserController : Controller
    {
        public ActionResult UserProfile()
        {
            if (Request.HttpMethod == "POST")
            {
                ViewBag.FirstName = Request.Form["age"];
                ViewBag.LastName = Request.Form["userFirstName"];   
                ViewBag.Age = Request.Form["userLastName"];
                ViewBag.Work = Request.Form["work"];
                ViewBag.Gender = Request.Form[4];
                return View("UserProfileResult");
            }
            string[] gender = { "Male", "Female"};
            ViewBag.Gender = gender;
            return View();
        }
    }
}