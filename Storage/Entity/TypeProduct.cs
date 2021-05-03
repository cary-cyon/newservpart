using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class TypeProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string name { get; set; }
        public List<ProductQrcodewithType> Products { get; set; } 
        public List<UserType> TargetTypes { get; set; }
        public List<UserType> AntiTargetTypes { get; set; }

        public TypeProduct Stock(double value)
        {
            TypeProduct X = this;
            for (int i = 0; i < X.Products.Count(); i++)
            {
                X.Products[i].Price = (1 - value) * X.Products[i].Price;
            }
            return X;
        }

    }
}
