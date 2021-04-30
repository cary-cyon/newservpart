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
        public User InfoUser(int id)
        {
            return _con.Users.FirstOrDefault(Us => Us.ID == id);
        }
        public void AddNewUser(User user)
        {
            _con.Users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _con.Users;
        }
        public UserManager(AshanContext con)
        {
            _con = con;
        }
    }
}
