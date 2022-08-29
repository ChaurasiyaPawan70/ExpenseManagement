using ExpenseManagament.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PurposeMaster> PurposeMaster { get; set; }
        public DbSet<CurrencyMaster> CurrencyMaster { get; set; }
        public DbSet<CategoryMaster> CategoryMaster { get; set; }
        public DbSet<PurposeCategoryLink> PurposeCategoryLink { get; set; }


    }
}
