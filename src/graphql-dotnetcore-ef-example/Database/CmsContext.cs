namespace GraphQLCMS.Database
{
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ArticleTag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("article");
            modelBuilder.Entity<Author>().ToTable("author");
            modelBuilder.Entity<ArticleTag>().ToTable("article_tag");
            modelBuilder.Entity<Category>().ToTable("category");
        }
    }
}
