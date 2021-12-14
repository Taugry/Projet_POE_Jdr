using Projet_Jdr.DAO;
using Projet_Jdr.Models;
using Projet_Jdr.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Projet_Jdr.Controllers
{
    public class JdrController : Controller
    {
        private static MyContext context = new MyContext();
        private UserDAO userDao = new UserDAO(context);
        private GameDAO gameDao = new GameDAO(context);

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

        public void SaveGame()
        {
           /* int id = (int)Session["user_id"];
            User user = userDao.FindById(id);

            string savegame = user.SavedGame;

            if (savegame.Length != 0)
            {
                savegame += ';';
            }*/
        }
    }
}