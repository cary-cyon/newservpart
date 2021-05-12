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
        public UserManager(AshanContext con)
        {
            _con = con;
        }

        public User InfoUser(int id)
        {
            return _con.Users.FirstOrDefault(Us => Us.ID == id);
        }
        public void AddNewUser(User user)
        {
            _con.Users.Add(user);
            _con.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return _con.Users.ToList();
        }
        public User GetIdentity(string Name)
        {   
            var res = _con.Users.FirstOrDefault(s => s.e_mail == Name);
            res.password = null;
            return res;
        }
        public User ChangeClass(int user_id, int class_id)
        {
            User T = new User();
            T = _con.Users.FirstOrDefault(us => us.ID == user_id);
            UserClass X = new UserClass();
            X = _con.UserClasses.FirstOrDefault(cl => cl.ID == class_id);

            if (X != null && T != null)
            { 
                _con.Users.FirstOrDefault(us => us.ID == user_id).userClass = _con.UserClasses.FirstOrDefault(cl => cl.ID == class_id);
            }
            return _con.Users.FirstOrDefault(us => us.ID == user_id);
        }
    }
}
