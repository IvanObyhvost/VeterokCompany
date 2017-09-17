using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterokCompany.DAL.Entites;

namespace VeterokCompany.DAL.EF
{
    public class VeterokCompanyContext : DbContext
    {
        public VeterokCompanyContext() : base("DbConnection") { }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<WorkProductEntity> WorkProducts { get; set; }
        public DbSet<IngredientsEntity> Ingredients { get; set; }
        public DbSet<WorkIngredientEntity> WorkIngredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.IdCategory);

            modelBuilder.Entity<IngredientsEntity>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.Ingredients)
                .HasForeignKey(x => x.IdProduct);
        }
    }
}
