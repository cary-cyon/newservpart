using Microsoft.EntityFrameworkCore;
using servPart.Models;
using servPart.Storage;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace servPart.Managers.StockManager
{

    public class StockManager
    {
        private AshanContext _con;
        public StockManager(AshanContext con)
        {
            _con = con;
        }
        public Stock getbyID(int id)
        {
            return _con.Stocks.FirstOrDefault(S => S.ID == id);
        }
    }
}