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

            Users = new List<User>() { 
            new User() {ID = 0,
                        name = "Pcelov",
                        sum_buy = -1,
                        br_day = "00000000",
                        num_buy = 0},
            new User() {ID = 1,
                        name = "Komarkov",
                        sum_buy = 2000,
                        br_day = "12072000",
                        num_buy = 5}};
            Histories = new List<History>() { new History() {
            User = Users[0],
            Products = new List<Product>(),
            TimeDate = "12122020",
            },
            new History() {
            User = Users[1],
            Products = new List<Product>(),
            TimeDate = "18122020",
            }
            };
            Images = new List<Image>();
        }
        public DbSet<Product> Products { get; set; } // delete
        public List<TypeProduct> Types { get; set; }
        public List<ProductQrcodewithType> ProductQrcodes { get; set; }
        public List<Producter> Producters { get; set; }
        public List<History> Histories { get; set; }
        public List<User> Users { get; set; }
        public List<UserClass> UserClasses { get; set; }
        public List<UserType> UserTypes { get; set; }
        public List<Image> Images { get; set; }
    }
}
