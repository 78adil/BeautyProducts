using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;

namespace BeautyProducts.Model
{
    public class ProductsDb: DbContext
    {
        public ProductsDb()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=Products.db");

        public ProductsDb(DbContextOptions<ProductsDb> options)
            : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
    
}
}
