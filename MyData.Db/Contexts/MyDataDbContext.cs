using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using MyData.Db.Models;

namespace MyData.Db.Contexts
{
    public class MyDataDbContext : DbContext
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options) : base(options)
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

        public DbSet<StaffInfo> StaffInfos { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
    }
}