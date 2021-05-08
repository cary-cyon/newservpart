using Microsoft.EntityFrameworkCore;
//using servPart.Models;
using servPart.Storage;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace servPart.Managers.StockManager
{

    public class StockByClassManager
    {
        private AshanContext _con;
        public StockByClassManager(AshanContext con)
        {
            _con = con;
        }
        public StockByClass getbyID(int id)
        {
            return _con.StocksByClass.FirstOrDefault(S => S.ID == id);
        }
    }
}