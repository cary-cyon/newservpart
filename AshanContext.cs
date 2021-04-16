using Microsoft.EntityFrameworkCore;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart
{
    public class AshanContext: DbContext
    {
        public AshanContext(DbContextOptions<AshanContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeProduct> Types { get; set; }
    }
}
