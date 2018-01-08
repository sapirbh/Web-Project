using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string UserEmail, string Password)
        {
            UsersDataAccess u = new UsersDataAccess();

            var requestedUser = u.CheckLogin(UserEmail, Password);
            if(requestedUser == null)
            {
                return Json(new
                {
                    Success = false
                });
            }
            else
            {
                System.Web.HttpContext.Current.Session["user"] = requestedUser.Id;
                System.Web.HttpContext.Current.Session.Timeout = 30;
                return View();
            }
        }

        public ActionResult AddNewUser(string UserEmail, string FirstName, string LastName, string Password)
        {
            UsersDataAccess u = new UsersDataAccess();
            var newUser = u.AddUser(UserEmail, FirstName, LastName, Password);
            if (newUser == null)
            {
                return Json(new
                {
                    Success = false
                });
            }
            else
            {
                System.Web.HttpContext.Current.Session["user"] = newUser.Id;
                System.Web.HttpContext.Current.Session.Timeout = 30;

                return View();
            }
        }


    }
}
