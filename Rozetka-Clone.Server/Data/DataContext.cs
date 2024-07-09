using Microsoft.EntityFrameworkCore;
using Rozetka_Clone.Server.Entity.Categories;

namespace Rozetka_Clone.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Categories> dbCategories { get; set; }
        public DbSet<SubCategories> dbSubCategories { get; set; }
        public DbSet<CategoryUnion> dbCategoriesUnion { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryUnion>()
                .HasOne<Categories>()
                .WithMany()
                .HasForeignKey(c => c.categoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CategoryUnion>()
                .HasOne<SubCategories>()
                .WithMany()
                .HasForeignKey(c => c.subCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
