using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdminDashBoardMVC
{
    public class CheckAdminIdentity
        : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"] == null)
                filterContext.Result =
                    new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                    {
                        { "controller","Home"},
                        { "action","Login"}
                    });
        }
    }
}