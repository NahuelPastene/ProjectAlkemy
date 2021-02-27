using Microsoft.EntityFrameworkCore;
using ProjectAlkemy.Model;
using System;

namespace ProjectAlkemy.Repository
{
    public class AlkemyContext : DbContext
    {
        public AlkemyContext(DbContextOptions<AlkemyContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Subject>().HasKey(x => x.Id);
            modelBuilder.Entity<Subject>().HasOne(x => x.Teacher).WithMany().HasForeignKey(x => x.TeacherId);
        }
    }
}
