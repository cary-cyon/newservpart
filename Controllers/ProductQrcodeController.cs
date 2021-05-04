﻿using Microsoft.AspNetCore.Mvc;
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
    public class ProductQrcodeController : Controller
    {
        private ProductManager _manager;
        public ProductQrcodeController(ProductManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public ProductQrcodewithType GetbyQr(string Qr)
        {
            return _manager.GetByQrcode(Qr);
        }
    }
}
