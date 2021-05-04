using Microsoft.AspNetCore.Mvc;
using servPart.Managers.ProductManager;
using servPart.Models;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStock1_1Controller : Controller
    {
        private ProductManager _manager;
        public ProductStock1_1Controller(ProductManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public List<ProductQrcodewithType> ShowStocks1_1(string Qr)
        {
            return _manager.ShowStocksProdukts(Qr);
        }
    }
}
