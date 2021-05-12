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
        public void UpdateImage(string Qr,int id)
        {
            var pic = _con.ProductQrcodes.FirstOrDefault(s => s.Qrcode == Qr);
            pic.Picture = File.ReadAllBytes("Storage/Images/" + id.ToString() + ".jpg");
            //_con.ProductQrcodes.Update();
            _con.SaveChanges();
        }

    }
}
