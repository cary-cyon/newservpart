using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using servPart.Managers.ProductManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeUserClassController1 : Controller
    {
        private UserManager _man;
        public ChangeUserClassController1(UserManager man)
        {
            _man = man;
        }


        [HttpPost]
        public User ChangeClass(int id_user, int id_class)
        {
           return _man.ChangeClass(id_user, id_class);
        }

    }
}