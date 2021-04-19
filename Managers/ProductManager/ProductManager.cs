using Microsoft.EntityFrameworkCore;
using servPart.Models;
using servPart.Storage;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    
    public class ProductManager : IProductManager, IProductQrcodeManager
    {
        private AshanContext _con;
        public ProductManager(AshanContext con)
        {
            _con = con;
        }
        public ProductGetRes getbyID(int id)
        {
            return _con.Products.FirstOrDefault(st => st.ID == id).Get_Res();
        }

        public ProductQrGetRes GetByQrcode(string Qr)
        {
            return _con.ProductQrcodes.FirstOrDefault(st => st.Qrcode == Qr).GetRes();
        }
    }
}
