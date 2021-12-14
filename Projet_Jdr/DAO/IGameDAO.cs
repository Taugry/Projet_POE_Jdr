using Projet_Jdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jdr.DAO
{
    public interface IGameDAO
    {
        List<Game> FindAll();
        Game FindById(int id);
    }
}
