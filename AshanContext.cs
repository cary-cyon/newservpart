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

            ProductQrcodes = new List<ProductQrcodewithType>() {

            new ProductQrcodewithType()
                {
                id =0,
                Price = 200,
                Name = "Cheburek",
                Qrcode = "0"
                },
            new ProductQrcodewithType()
                {
                id =1,
                Price = 200,
                Name = "Chebupel",
                Qrcode = "1"
                },
            new ProductQrcodewithType()
                {
                id =2,
                Price = 200,
                Name = "Cheburek2",
                Qrcode = "2"
                },
            new ProductQrcodewithType()
                {
                id =3,
                Price = 200,
                Name = "Chebupel2",
                Qrcode = "3"
                },
             new ProductQrcodewithType()
                {
                id =3,
                Price = 200,
                Name = "Chebupel3",
                Qrcode = "4"
                }
            };
             Stocks = new List<Stock>()
            {
                new Stock()
                {
                    ID = 0,
                    Value = 5,
                    product =   ProductQrcodes[0]

                }
            };

            StocksOfType = new List<StockOfType> ();

            Stocks1_1 = new List<Stock1_1>()
            {
                new Stock1_1()
                {
                    ID = 0,
                    Value = 10,
                    products = new List<ProductQrcodewithType>()  { ProductQrcodes[2],ProductQrcodes[3], ProductQrcodes[4] }

                }
            };

    }
        public DbSet<Product> Products { get; set; } // delete
        public List<TypeProduct> Types { get; set; }
        public List<ProductQrcodewithType> ProductQrcodes { get; set; }
        public List<Producter> Producters { get; set; }
        public List<History> Histories { get; set; }
        public List<User> Users { get; set; }
        public List<UserClass> UserClasses { get; set; }
        public List<UserType> UserTypes { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<StockOfType> StocksOfType { get; set; }
        public List<Stock1_1> Stocks1_1 { get; set; }

    }
}
