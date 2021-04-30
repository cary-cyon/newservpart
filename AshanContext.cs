using Microsoft.EntityFrameworkCore;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart
{
    public class AshanContext : DbContext
    {
        public AshanContext(DbContextOptions<AshanContext> options) : base(options)
        {

            Users = new List<User>() { new User() {name = "Pcelov",
                                                   sum_buy = -1,
                                                   br_day = "00000000",
                                                   num_buy = 0} };
        }
        public DbSet<Product> Products { get; set; } // delete
        public List<TypeProduct> Types { get; set; }
        public List<ProductQrcodewithType> ProductQrcodes { get; set; }
        public List<Producter> Producters { get; set; }
        public List<History> Histories { get; set; }
        public List<User> Users { get; set; }
        public List<UserClass> UserClasses { get; set; }
        public List<UserType> UserTypes { get; set; }


    }
}
