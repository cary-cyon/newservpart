using Microsoft.AspNetCore.Mvc;
using servPart.Managers.UserManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserClassController1 : Controller
    {
        private UserClassManager _man;
        public UserClassController1(UserClassManager man)
        {
            _man = man;
        }

        [HttpGet]
        public UserClass GetClassIfo(int id)
        {
            return _man.InfoClass(id);
        }
        [HttpPost]
        public void AddUser(int user_id, int class_id)
        {
             _man.AddNewUser(user_id, class_id);
        }
       
        
    }
}
