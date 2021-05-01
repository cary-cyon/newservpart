using Microsoft.AspNetCore.Mvc;
using servPart.Managers.UserManager;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryController : Controller
    {
        private HistoryManager _man;
        public HistoryController( HistoryManager man)
        {
            _man = man;
        }
        
        [HttpGet]
        public List<History> Get(int id)
        {
            return _man.GetHistory(id);
        }

        [HttpPost]
        public void Add(History his)
        {
            _man.AddHistory(his);
        }
    }
}
