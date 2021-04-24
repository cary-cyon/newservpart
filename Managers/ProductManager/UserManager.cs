using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    public class UserManager: IUserManager
    {
        private AshanContext _con;
        public User InfoUser( string name)
        {
            return _con.Users.FirstOrDefault(x => x.name == name);
        }
        public void AddNewUser()
        {

        }
        public UserManager(AshanContext con)
        {
            _con = con;
        }
    }
}
