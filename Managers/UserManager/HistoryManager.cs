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
        public void AddHistory(History his, int id) 
        { 

            for( int i=0; i < his.Products.Count; i++) {
                his.Products[i] = _con.ProductQrcodes.FirstOrDefault(p => p.Qrcode == his.Products[i].Qrcode);
            }
            var user = _con.Users.FirstOrDefault(s => s.ID == id);
            user.num_buy += 1;
            user.sum_buy += his.Sum;
            his.User = user;
            _con.Histories.Add(his);
            _con.SaveChanges();
        }
    }
}
