using servPart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    interface IProductQrcodeManager
    {
        public ProductQrGetRes GetByQrcode(string Qr);
    } 

}
