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
    public class StockOfTypeController : Controller
    {
            private StockOfTypeManager _man;
            public StockOfTypeController(StockOfTypeManager man)
            {
                _man = man;
            }

            [HttpGet]
           StockOfType Get(int id)
            {
                return _man.getbyID(id);
            }


     }
 }
