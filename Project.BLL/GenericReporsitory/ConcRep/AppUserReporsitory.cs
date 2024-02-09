using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericReporsitory.ConcRep
{
    public class AppUserReporsitory:BaseRepository<AppUser>
    {

        public AppUser UserNameAra(string userName)
        {   //UserName Ara eşit ise user dondur geriye
            AppUser user = FirstOrDefault(x => x.UserName == userName);
            return user;
        }

    }
}
