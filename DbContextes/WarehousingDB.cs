using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using warehousing_backend.Entities.Base;
using warehousing_backend.Enums;

namespace warehousing_backend.DbContextes
{
    public class WarehousingDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<Output> Outputs { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=DBFiles\librarydb.sqlite");
        }
    }
}