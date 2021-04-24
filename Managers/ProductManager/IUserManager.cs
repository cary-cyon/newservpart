using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    interface IUserManager
    {
        void AddNewUser();
        User InfoUser(string name);
    }
}
