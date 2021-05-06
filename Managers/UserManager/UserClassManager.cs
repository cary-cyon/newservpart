using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.UserManager
{
    public class UserClassManager
    {
        private AshanContext _con;
        public UserClassManager(AshanContext con)
        {
            _con = con;
        }

        public UserClass InfoClass(int id)
        {
            return _con.UserClasses.FirstOrDefault(Us => Us.ID == id);
        }
        public void AddNewUser(int user_id, int class_id)
        {
            User T = new User();
            T = _con.Users.FirstOrDefault(us => us.ID == user_id);
            UserClass X = new UserClass();
            X = _con.UserClasses.FirstOrDefault(cl => cl.ID == class_id);

            if (X != null && T != null)
            {
                _con.UserClasses.FirstOrDefault(cl => cl.ID == class_id).Users.Add(T);
                //_con.Users.FirstOrDefault(us => us.ID == user_id).userClass = _con.UserClasses.FirstOrDefault(cl => cl.ID == class_id);
            }
           
        }
        public List<UserClass> GetUserClasses()
        {
            return _con.UserClasses.ToList();
        }


    }
}
