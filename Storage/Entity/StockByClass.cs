using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class StockByClass
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { set; get; }
		public List<ProductQrcodewithType> products { set; get; }
		public UserClass _class { set; get; }
	    public double Value { set; get; }
	}
}
