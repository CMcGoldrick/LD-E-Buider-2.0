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

/*
insert into questions(userId, TopicId, Q, A, CreatedDate)
  values
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q1', 'A1', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q2', 'A2', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q3', 'A3', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q4', 'A4', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q5', 'A5', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q6', 'A6', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q7', 'A7', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q8', 'A8', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q9', 'A9', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q10', 'A10', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q11', 'A11', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q12', 'A12', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q13', 'A13', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q14', 'A14', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q15', 'A15', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q16', 'A16', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q17', 'A17', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q18', 'A18', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q19', 'A19', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q20', 'A20', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q21', 'A21', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q22', 'A22', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q23', 'A23', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q24', 'A24', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q25', 'A25', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q26', 'A26', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q27', 'A27', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q28', 'A28', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q29', 'A29', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q30', 'A30', GETDATE()),
  ('9776506B-8CFE-448F-1BF5-08D7DCE61A3B', 1005, 'Q31', 'A31', GETDATE())
    */