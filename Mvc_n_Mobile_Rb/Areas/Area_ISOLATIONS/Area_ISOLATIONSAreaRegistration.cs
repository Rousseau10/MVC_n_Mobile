using System.Web.Mvc;

namespace Mvc_n_Mobile_Rb.Areas.Area_ISOLATIONS
{
    public class Area_ISOLATIONSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area_ISOLATIONS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Area_ISOLATIONS_default",
                "Area_ISOLATIONS/{controller}/{action}/{id}",
               //ew { action = "Index", id = UrlParameter.Optional }
                new { action = "TestView", id=UrlParameter.Optional }
            );
        }
    }
}
