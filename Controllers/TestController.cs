using Microsoft.AspNetCore.Mvc;
using servPart.MOK_server;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        mok_product _mok;
        public TestController(mok_product mok)
        {
            _mok = mok;
        }
        [HttpGet]
        public ProductQrcodewithType GetbyQR(string QR)
        {
            return _mok.Get(QR);
        }
    }


}
