using DiaryApp.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        //creating a table by entityframework
        public DbSet<DiaryEntry> DiaryEntries { get; set; }


        //seeding data to database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var createdDate = new DateTime(2024, 1, 1);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "Went hiking", Content = "Went hiking wiht Joe!", Created = createdDate },
                new DiaryEntry { Id = 2, Title = "Went to Disneyland", Content = "Went to Disneyland wiht Joe!", Created = createdDate, },
                new DiaryEntry { Id = 3, Title = "Went diving", Content = "Went diving wiht Joe!", Created = createdDate, }
                );
        }
    }
}
