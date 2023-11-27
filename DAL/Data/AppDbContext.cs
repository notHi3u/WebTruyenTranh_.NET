using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //thêm data set để lấy dât tuef csdl, vd:
        //public DbSet<Book> BooksList { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Find> Finds { get; set; }
        public DbSet<HashTag> Hashtags { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<StoryPage> StoryPages { get; set; }
        public DbSet<User_Account> UserAccounts { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
        .HasKey(c => new { c.UserId, c.StoryId });

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Story)
                .WithMany(s => s.Comments)
                .HasForeignKey(c => c.StoryId);

            modelBuilder.Entity<Find>()
                .HasKey(f => new { f.StoryId, f.TagId });

            modelBuilder.Entity<Favorite>()
                .HasKey(f => new { f.UserId, f.StoryId });

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Story)
                .WithMany(s => s.Favorites)
                .HasForeignKey(f => f.StoryId);

            modelBuilder.Entity<Post>()
                .HasKey(p => new { p.UserId, p.StoryId });

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Story)
                .WithMany(s => s.Posts)
                .HasForeignKey(p => p.StoryId);

            modelBuilder.Entity<Report>()
                .HasKey(r => new { r.UserId, r.StoryId });

            modelBuilder.Entity<Report>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reports)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Report>()
                .HasOne(r => r.Story)
                .WithMany(s => s.Reports)
                .HasForeignKey(r => r.StoryId);

            modelBuilder.Entity<Chapter>()
                .HasKey(c => c.ChapterId);

            modelBuilder.Entity<Chapter>()
                .HasOne(c => c.Story)
                .WithMany(s => s.Chapters)
                .HasForeignKey(c => c.StoryId);

            modelBuilder.Entity<StoryPage>()
                .HasKey(sp => new { sp.ChapterId, sp.PageNumber });

            modelBuilder.Entity<StoryPage>()
                .HasOne(sp => sp.Chapter)
                .WithMany(c => c.Pages)
                .HasForeignKey(sp => sp.ChapterId);

            modelBuilder.Entity<Story>()
                .HasKey(s => s.StoryId);

            modelBuilder.Entity<Rating>()
                .HasKey(r => new { r.UserId, r.StoryId });

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Story)
                .WithMany(s => s.Ratings)
                .HasForeignKey(r => r.StoryId);
            modelBuilder.Entity<HashTag>()
                .HasKey(h => h.TagId);
            modelBuilder.Entity<User_Account>()
                .HasKey(u => u.UserId);
        }
    }
}
