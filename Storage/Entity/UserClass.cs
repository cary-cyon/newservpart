using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace servPart.Storage.Entity
{
    public class UserClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string name { set; get; }
        public double start_sum { set; get; }
        public double end_sum { set; get; }

        public List<User> Users { get; set; }
    }
}