using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using servPart.Managers.ProductManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductManager _manager;
        //private readonly ILogger<ProductController> _logger;

        public ProductController(ProductManager manager)
        {
            _manager = manager;
        }

        //public ProductController(ILogger<ProductController> logger)
        //{
        //    _logger = logger;

        //}
        [HttpGet]
        public ProductQrcodewithType GetbyID(int id, int User_ID)
        {
            return _manager.getbyID(id, User_ID);
        }
    }
}
