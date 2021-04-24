using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Storage.Entity
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Key]
        public string name { set; get; }
        [MaxLength(8)]
        public string br_day { set; get; }
        public double sum_bay { set; get; }
        public int num_bay { set; get; }

        public string email { set; get; }

        public List<History> History { set; get; }

       

    public UserType type { set; get; }
        public UserClass userClass { set; get; }

    }
}
