using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class ProductQrcodewithType: ProductQrcode
    {
        public List<TypeProduct> Types { set; get; }
        public Producter Producter { set; get; }
    }
}
