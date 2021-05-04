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
    public class Stock1_1Controller : Controller
    {
        
   
            private Stock1_1Manager _man;
            public Stock1_1Controller(Stock1_1Manager man)
            {
                _man = man;
            }

            [HttpGet]
            public Stock1_1 Get(int id)
            {
                return _man.getbyID(id);
            }


        
    }
}
