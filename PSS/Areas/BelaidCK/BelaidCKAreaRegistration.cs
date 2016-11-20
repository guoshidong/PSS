using System.Web.Mvc;

namespace PSS.Areas.BelaidCK
{
    public class BelaidCKAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BelaidCK";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BelaidCK_default",
                "BelaidCK/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}