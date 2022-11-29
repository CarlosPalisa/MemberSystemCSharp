using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MemberSystemCSharp.Controllers;
using MemberSystemCSharp.Models;
using MemberSystemCSharp.Models.Users;

namespace MemberSystemCSharp.Filters
{
    public class VerifySession : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var oUser = (string)HttpContext.Current.Session["User"];
            
            base.OnActionExecuted(filterContext);

            if (oUser == null)
            {
                if(filterContext.Controller is AccesController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Acces/Index");
                }
            }
        }
    }
}