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
       
        public DbSet<TypeProduct> Types { get; set; }
        public DbSet<ProductQrcodewithType> ProductQrcodes { get; set; }
        public DbSet<Producter> Producters { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserClass> UserClasses { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockOfType> StocksOfType { get; set; }
        public DbSet<Stock1_1> Stocks1_1 { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<StockByClass> StocksByClass { get; set; }

}
}
