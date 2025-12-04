using Microsoft.EntityFrameworkCore;
using Models;
using Fixtures;

namespace Data
{
    public class GesApproDbContext : DbContext
    {
        public DbSet<Approvisionnement> Approvisionnements { get; set; } = null!;
        public DbSet<Fournisseur> Fournisseurs { get; set; } = null!;
        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<ApproArticle> ApproArticles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fournisseur>().HasData(FournisseurFixtures.GetFournisseurs());
            modelBuilder.Entity<Article>().HasData(ArticleFixtures.GetArticles());
            modelBuilder.Entity<Approvisionnement>().HasData(ApprovisionnementFixtures.GetApprovisionnements());
            modelBuilder.Entity<ApproArticle>().HasData(ApproArticleFixtures.GetApproArticles());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=127.0.0.1;Port=5432;Database=GesEmpDB;Username=postgres;Password=passer"
            );
        }
    }
}
