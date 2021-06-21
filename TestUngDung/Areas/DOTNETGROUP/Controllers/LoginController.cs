using ModelEF;
using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.DOTNETGROUP.Data;

namespace TestUngDung.Areas.DOTNETGROUP.Controllers
{
    public class LoginController : Controller
    {
        // GET: DOTNETGROUP/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var user = new UserDao();
                var result = user.login(login.username, login.password);
                if(result == 1)
                {
                    //ModelState.AddModelError("", "Đăng nhập thành công");
                    Session.Add(Constants.USER_SESSION,login);
                    return RedirectToAction("Index","Home");
                }
                if(login.username==null && login.password==null)
                {
                    ModelState.AddModelError("", "Please enter the information");
                }
                else
                {
                    ModelState.AddModelError("", "Login Failed");
                }
            }
            return View();
        }
    }
}