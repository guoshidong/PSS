using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSS.App_Start
{
    public class LoginAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 验证身份
        /// </summary>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["user"] != null;
        }

        /// <summary>
        /// 验证失败之后，要做什么事情
        /// </summary>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //UrlHelper.GenerateUrl()
            filterContext.HttpContext.Response.Redirect("~/Home/Login");
        }
    }
}