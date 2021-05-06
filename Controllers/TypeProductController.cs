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
    public class TypeProductController : Controller
    {
        private TypeManager _man;
        public TypeProductController(TypeManager man)
        {
            _man = man;
        }

        [HttpGet]
        public TypeProduct Get(int id)
        {
            return _man.getbyID(id);
        }

    }
}
