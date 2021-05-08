using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.MOK_server
{
    public class mok_product
    {
        public List<ProductQrcodewithType> Products { get; set; }

        public mok_product()
        {
            ProductQrcodewithType adition = new ProductQrcodewithType();

            adition.Name = "Moloco";
            adition.Price = 500;
            adition.id = 1;
            adition.Qrcode = "4600819351681";
            adition.Producter = new Producter();
            adition.Types = new List<TypeProduct>();

            Products = new List<ProductQrcodewithType>() { adition };
        }
        public ProductQrcodewithType Get(string QR)
        {
            return Products.FirstOrDefault(st => st.Qrcode == QR);
        }

    }
}
