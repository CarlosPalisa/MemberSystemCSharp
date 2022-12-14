using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberSystemCSharp.Controllers
{
    public class AccesController : Controller
    {
        // GET: Acces
        public ActionResult Index()
        {
            return View();
        } 
        public ActionResult Enter(string user, string pass)
        {
            try
            {
                if (user != "admin@admin" && pass != "1234")
                {
                    return Content("-1");
                }
                else
                {
                    
                    Session["User"] = "Carlos";
                    
                    return Content("1");
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error..." + ex.Message);
            }
        }
        public ActionResult Logoff()
        {
            Session["User"] = null;
        }

    }
}