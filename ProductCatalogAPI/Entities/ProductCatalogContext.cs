using Microsoft.EntityFrameworkCore;

namespace ProductCatalogAPI.Entities
{
    public class ProductCatalogContext : DbContext
    {
        public ProductCatalogContext() { }

        public ProductCatalogContext(DbContextOptions<ProductCatalogContext> options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Category");

                entity.Property(e=>e.CategoryId).HasColumnName("Category_Id").ValueGeneratedOnAdd();
                entity.Property(e=>e.CategoryName).HasColumnName("Category_Name");
                entity.Property(e=>e.CategoryDescription).HasColumnName("Category_Description").HasMaxLength(150);
            });
        }
    }
}
