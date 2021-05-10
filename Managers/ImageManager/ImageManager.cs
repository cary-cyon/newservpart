using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.IO;
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
            Image res = new Image();
            res = _con.Images.FirstOrDefault(s => s.ID == id);
            if (res != null)
            {
                res.Picture = File.ReadAllBytes("Storage/Images/" + res.addres);
            }
            return res; 
        }
    }
}
