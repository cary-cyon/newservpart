using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Models
{
    public class ProductQrGetRes
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public string Qrcode { set; get; }
        public ProductQrGetRes(string name, double price, string Qr)
        {
            Name = name;
            Price = price;
            Qrcode = Qr;

        }
    }
}
