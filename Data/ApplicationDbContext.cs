using System;
using System.Collections.Generic;
using System.Text;
using Lethal.Developer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lethal.Developer.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Theory> Theory { get; set; }
        public DbSet<Result> Results { get; set; }
        public new DbSet<ApplicationUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(
                        new ApplicationUser { AccessFailedCount = 0, ConcurrencyStamp = string.Empty, Email = "mcgoldrick.development@gmail.com", EmailConfirmed = true, Id = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B"), LockoutEnabled = false, LockoutEnd = null, NormalizedEmail = "mcgoldrick.development@gmail.com", NormalizedUserName = "ciaranmcgold", PasswordHash = "5f4dcc3b5aa765d61d8327deb882cf99", PhoneNumber = "3127850089", PhoneNumberConfirmed = false, SecurityStamp = string.Empty, TwoFactorEnabled = false, UserName = "ciaranmcgold" }
                        );
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(n => n.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasData(
                        new Topic { Id = 1, Name = "Data Structures", UserId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B"), CreatedDate = DateTime.Now  },
                        new Topic { Id = 2, Name = "C#", UserId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B"), CreatedDate = DateTime.Now  },
                        new Topic { Id = 3, Name = "ASP.NET", UserId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B"), CreatedDate = DateTime.Now  }
                    );
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(n => n.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                //entity.HasData(
                //        new Question { Id = 1, Q = "<p>What is an interface?</p>", A = "", TopicId = 1}

                //    );
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(n => n.UserId).IsRequired();
               
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Theory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(n => n.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Theory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
