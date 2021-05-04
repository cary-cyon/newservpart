using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    public class Stock1_1Manager
    {
        private AshanContext _con;
        public Stock1_1Manager(AshanContext con)
        {
            _con = con;
        }
        public Stock1_1 getbyID(int id)
        {
            return _con.Stocks1_1.FirstOrDefault(S => S.ID == id);
        }
    }
}
