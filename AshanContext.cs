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

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeProduct> Types { get; set; }
        public DbSet<ProductQrcode> ProductQrcodes { get; set; }
        public DbSet<Producter> Producters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserClass> UserClasses {get; set;}
        public DbSet<UserType> UserTypes { get; set; }
    }
}
