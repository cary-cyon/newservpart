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
    public class UserController : Controller
    {
        private UserManager _man;
        [HttpGet]
        public User GetUser(int id)
        {
            return _man.InfoUser(id);
        }
        [HttpPost]
        public void AddUser(User user)
        {
            _man.AddNewUser(user);
        }
        //[HttpGet]
        //public List<User> GetAll()
        //{
        //    return _man.GetUsers();
        //}
        public UserController(UserManager man)
        {
            _man = man;
        }
    }
}
