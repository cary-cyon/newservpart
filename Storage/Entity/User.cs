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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string name { set; get; }
        [MaxLength(8)]
        public string br_day { set; get; }
        public double sum_buy { set; get; }
        public int num_buy { set; get; }
        public string password { set; get; }
        public string e_mail { set; get; }
        public string tel { get; set; }
        public List<History> Histories { get; set; }
        public UserType type { set; get; }
        public UserClass userClass { set; get; }

        /*
        public static bool operator ==(User other, User it )
        {
            if (it.ID == other.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(User other, User it)
        {
            if (it.ID == other.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/
    }
}
