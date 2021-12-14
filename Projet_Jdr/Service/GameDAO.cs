using Projet_Jdr.DAO;
using Projet_Jdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Jdr.Service
{
    public class GameDAO : IGameDAO
    {
        private MyContext db;

        public GameDAO(MyContext db)
        {
            this.db = db;
        }
        public List<Game> FindAll()
        {
            return db.Games.ToList();
        }

        public Game FindById(int id)
        {
            return db.Games.Find(id);
        }
    }
}