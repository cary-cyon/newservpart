using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using servPart.Managers.UserManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using servPart.Managers.StockManager;

namespace servPart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockByClassController : Controller
    {
        private StockByClassManager _man;
        public StockByClassController(StockByClassManager man)
        {
            _man = man;
        }

        [HttpGet]
        public StockByClass Get(int id)
        {
            return _man.getbyID(id);
        }


    }
}