using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    public class TypeManager
    {
        private AshanContext _con;
        public TypeManager(AshanContext con)
        {
            _con = con;
        }
        public TypeProduct getbyID(int id)
        {
            return _con.Types.FirstOrDefault(S => S.ID == id);
        }
    }
}
