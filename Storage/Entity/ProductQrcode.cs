//using servPart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class ProductQrcode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        [Key]
        [MaxLength(13)]
        public string Qrcode { set; get; }
        public string Name { set; get; }

        public double Price { set; get; }

        //public ProductQrGetRes GetRes()
        //{
        //    return new ProductQrGetRes(Name, Price, Qrcode);
        //}

       
    }
}
