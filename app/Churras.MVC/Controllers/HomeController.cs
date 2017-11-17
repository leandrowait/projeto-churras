using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Churras.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("Events/List");
        }
    }
}