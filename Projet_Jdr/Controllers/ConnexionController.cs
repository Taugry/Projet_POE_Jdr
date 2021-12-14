using Projet_Jdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Jdr.Controllers
{
    public class ConnexionController : Controller
    {
        private MyContext context = new MyContext();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(User user)
        {
            string msgErreur = "Echec authentification";
            if (ModelState.IsValid)
            {
                User userDB = context.Users.SingleOrDefault(u => u.Email.Equals(user.Email));
                if (userDB != null)
                {
                    if (userDB.Password.Equals(user.Password))
                    {
                        if (userDB.Admin)
                        {
                            Session["Admin"] = userDB.Admin; //enregistrement de userdb.admin dans la session
                        }
                        Session["user_id"] = userDB.Id;
                        Session["username"] = userDB.Username;
                        return RedirectToAction("ConnecterHomePage", "Index");
                    }
                    else
                    {
                        ViewBag.Error = msgErreur;
                    }
                }
                else
                {
                    ViewBag.Error = msgErreur;
                }
            }
            else
            {
                ViewBag.Error = msgErreur;
            }

            return View("Login", user);
        }

        public ActionResult Logout()
        {
            Session.Remove("user_id");
            Session.Remove("username");
            Session.Remove("Admin");
            return View("Login");
        }

        public ActionResult Authorisation()
        {
            return View();
        }


        public ActionResult Inscription()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inscription([Bind(Include = "Id,Username,Email,Password")] User utilisateur)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(utilisateur);
                context.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(utilisateur);
        }
    }
}