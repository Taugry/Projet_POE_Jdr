using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Jdr.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConnecterHomePage()
        {
            return View();
        }

        public ActionResult Parametres()
        {
            return View();
        }
    }
}