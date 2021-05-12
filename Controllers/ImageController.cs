using Microsoft.AspNetCore.Mvc;
using servPart.Managers.ImageManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        private ImageManager _man;
        public ImageController(ImageManager man )
        {
            _man = man;
        }
        [HttpGet]
        public Image GetImage(int id)
        {
            return _man.GetByID(id);
        }
        [HttpPost]
        public void UpImage(int id)
        {
            _man.UpdateImage(id);
        }
    }
}
