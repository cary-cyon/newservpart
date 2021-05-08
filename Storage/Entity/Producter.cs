using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace servPart.Storage.Entity
{
    public class Producter
    {
        [Key]
        public int ID { set; get; }
        public string name { set; get; }
        public List<ProductQrcodewithType> Products { set; get; } 
    }
}