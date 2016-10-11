using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNET_MVC_EXAMPLE.Custom
{
    
    public class Test : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "Home", action = "About" }));
        }
    }


}