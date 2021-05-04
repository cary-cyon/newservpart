using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ImageManager
{
    public class ImageManager
    {
        private AshanContext _con;
        public ImageManager(AshanContext con)
        {
            _con = con;
        }
        public Image GetByID(int id)
        {
            return _con.Images.FirstOrDefault(s => s.ID == id);
        }
    }
}
