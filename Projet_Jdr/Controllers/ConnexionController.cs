using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Jdr.Controllers
{
    public class ConnexionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Inscription()
        {
            return View();
        }
    }
}