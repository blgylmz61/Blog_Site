using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<PostLike> PostLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    IsAdmin = true,
                    Email = "admin@gmail.com",
                    Name = "Bilge",
                    SurName = "Karaca",
                    Password = "0661",
                    UserName = "blgkrc61"
                });

        }

    }
}
