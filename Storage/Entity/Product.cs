using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        public TypeProduct type { get; set; }

        public ProductGetRes Get_Res()
        {
            return new ProductGetRes(name, price);
        }
    }
}
