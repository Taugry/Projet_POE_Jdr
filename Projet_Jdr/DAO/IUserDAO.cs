﻿using Projet_Jdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jdr.DAO
{
    public interface IUserDAO
    {
        List<User> FindAll();
        User FindById(int id);
    }
}
