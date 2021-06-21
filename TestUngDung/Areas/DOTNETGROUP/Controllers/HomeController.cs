using ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.DOTNETGROUP.Controllers
{
    public class HomeController : Controller
    {
        // GET: DOTNETGROUP/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {

            Session[Constants.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");

        }
    }
}
