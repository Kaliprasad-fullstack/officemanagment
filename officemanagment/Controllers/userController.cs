using officemanagment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace officemanagment.Controllers
{
    public class userController : Controller
    {
        private userContext dbusers = new userContext();
        // GET: user
        public ActionResult Index()
        {
            return View(dbusers.Users.ToList());
        }
    }
}