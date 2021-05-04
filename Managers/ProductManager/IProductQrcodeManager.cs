using servPart.Models;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    interface IProductQrcodeManager
    {
        public ProductQrcodewithType GetByQrcode(string Qr);
    } 

}
