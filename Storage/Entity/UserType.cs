using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace servPart.Storage.Entity
{
    public class UserType
    {
        [Key]
        public int ID { set; get; }
        public List<User> Users { set; get; }
        public string name { set; get; }
    }
}