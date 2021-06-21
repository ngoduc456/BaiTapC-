using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.DOTNETGROUP.Controllers
{
    public class UserController : Controller
    {
        // GET: DOTNETGROUP/User
        //public ActionResult Index()
        //{
        //    var user = new UserDao();
        //    var userList = user.ListAll();
        //    return View(userList);
        //}
        public ActionResult Index(string searchString,int page=1,int pagesize=5)
        {
            var user = new UserDao();
            var userList = user.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchKeyWord = searchString;
            return View(userList);
        }
    }
}