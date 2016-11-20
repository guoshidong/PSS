using System.Web.Mvc;

namespace PSS.Areas.BelaidRK
{
    public class BelaidRKAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BelaidRK";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BelaidRK_default",
                "BelaidRK/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}