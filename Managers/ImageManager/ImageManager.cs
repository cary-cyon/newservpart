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
            return _con.Images.FirstOrDefault(s => s.ID == id);
        }
        public void UpdateImage(int id)
        {
            var pic = _con.Images.FirstOrDefault(s => s.ID == id);
            pic.Picture = File.ReadAllBytes("Storage/Images/" + id.ToString() + ".jpg");
            _con.Images.Update(pic);
            _con.SaveChanges();
        }

    }
}
