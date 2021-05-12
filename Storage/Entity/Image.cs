﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public byte[] Picture { set; get; }
        public string addres { get; set; }
        //[ForeignKey("ProductQrcodewithType")]
        //public int ProductQrcodewithTypeId { get; set; }
        //public ProductQrcodewithType product { get; set; }
     }
}
