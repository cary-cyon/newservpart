using servPart.Storage;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    
    public class ProductManager : IProductManager
    {
        private AshanContext _con;
        public ProductManager(AshanContext con)
        {
            _con = con;
        }
        public Product getbyID(int id)
        {
            return _con.Products.FirstOrDefault(st => st.ID == id);
        }
    }
}
