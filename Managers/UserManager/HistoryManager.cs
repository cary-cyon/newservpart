using Microsoft.EntityFrameworkCore;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.UserManager
{
    public class HistoryManager
    {
        private AshanContext _con;
        public HistoryManager(AshanContext con)
        {
            _con = con;
        }
        public List<History> GetHistory(int id)
        {
            return _con.Histories.Include(h => h.Products).Where(st => st.User.ID == id).ToList();
        }
        public void AddHistory(History his)
        {
            _con.Histories.Add(his);
        }
    }
}
