using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    public class UserManager: IUserManager
    {
        private AshanContext _con;
        public void InfoUser()
        {

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
