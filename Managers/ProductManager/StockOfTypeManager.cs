using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    public class StockOfTypeManager
    {
        private AshanContext _con;
        public StockOfTypeManager(AshanContext con)
        {
            _con = con;
        }
        public StockOfType getbyID(int id)
        {
            return _con.StocksOfType.FirstOrDefault(S => S.ID == id);
        }
    }
}
