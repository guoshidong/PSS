using PSS.App_Start;
using PSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PSS.Controllers
{
    public class HomeController : Controller
    {
        PSSEntities1 db = new PSSEntities1();
        [HttpGet]
        /// <summary>
        /// 提交登录
        /// </summary>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 提交登录按钮
        /// </summary>
        [HttpPost]
        public ActionResult Login(string LoginName, string LoginPwd)
        {
            LoginPwd = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(LoginPwd)));
            var i = from a in db.Emp
                    where a.LoginName == LoginName && a.LoginPwd == LoginPwd
                    select a;
            if (i.Count() == 0 )
            {
                return View();
            }
            else
            {
                //记录登录身份
                Session["user"] = LoginName;
                return RedirectToAction("Index", "Home");
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        /// Login验证当前页面
        // [Login]
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Depot() 
        {
            return View();
        }

        public ActionResult BBB()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}