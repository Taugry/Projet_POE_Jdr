using Projet_Jdr.DAO;
using Projet_Jdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Jdr.Service
{
    public class UserDAO : IUserDAO
    {
        private MyContext db;

        public UserDAO(MyContext db)
        {
            this.db = db;
        }
        public List<User> FindAll()
        {
            return db.Users.ToList();
        }

        public User FindById(int id)
        {
            return db.Users.Find(id);
        }
    }
}