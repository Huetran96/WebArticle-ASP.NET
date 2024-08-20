using Microsoft.EntityFrameworkCore;

namespace ArticleWeb.Models
{
    public class MyBlogContext : DbContext
    {
        public DbSet<Article> articles { get; set; }
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        


    }
}
