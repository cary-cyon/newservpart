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
            //ProductQrcodes = new List<ProductQrcodewithType>() {

            //new ProductQrcodewithType()
            //    {
            //    id =0,
            //    Price = 200,
            //    Name = "Cheburek"
            //    },
            //new ProductQrcodewithType()
            //    {
            //    id =1,
            //    Price = 200,
            //    Name = "Chebupel"
            //    },
            //new ProductQrcodewithType()
            //    {
            //    id =2,
            //    Price = 89.99,
            //    Qrcode = "4690363072835",
            //    Name = "Рис Круглозерный"
            //    },
            //new ProductQrcodewithType()
            //    {
            //    id =2,
            //    Price = 59.99,
            //    Qrcode = "4600819351681",
            //    Name = "Молоко.Просто"
            //    },
            //            new ProductQrcodewithType()
            //    {
            //    id =3,
            //    Price = 2290,
            //    Qrcode = "4711421955133",
            //    Name = "Оптическая игровая мышь"
            //    }
            //};
            // Stocks = new List<Stock>()
            //{
            //    new Stock()
            //    {
            //        ID = 0,
            //        Value = 5,
            //        product =   ProductQrcodes[0]

            //    }
            //};

            //StocksOfType = new List<StockOfType> ();
            //Users = new List<User>() {
            //new User() {ID = 0,
            //            name = "Pcelov",
            //            sum_buy = -1,
            //            br_day = "00000000",
            //            num_buy = 0},
            //new User() {ID = 1,
            //            name = "Komarkov",
            //            sum_buy = 2000,
            //            br_day = "12072000",
            //            num_buy = 5}};
            //Histories = new List<History>() { new History() {
            //User = Users[0],
            //Products = new List<ProductQrcodewithType>(){ProductQrcodes[0],ProductQrcodes[3] },
            //TimeDate = "12122020",
            //},
            //new History() {
            //User = Users[1],
            //Products = new List<ProductQrcodewithType>(){ProductQrcodes[1],ProductQrcodes[2] },
            //TimeDate = "18122020",
            //}
            //};
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
    }
}
