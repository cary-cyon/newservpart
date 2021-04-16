using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MolocoController : ControllerBase
    {
        

        private readonly ILogger<MolocoController> _logger;
        public MolocoController(ILogger<MolocoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public Sell Get()
        {

            return new Sell("Moloco");
        }
    }
}
