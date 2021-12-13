using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Jdr.Controllers
{
    public class JdrController : Controller
    {
        public ActionResult Game()
        {
            return View();
        }

        public ActionResult EndGame()
        {
            return View();
        }

        public ActionResult Synopsis()
        {
            return View();
        }
    }
}