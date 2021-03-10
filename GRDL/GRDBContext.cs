using GRModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRDL
{
    public class GRDBContext : DbContext
    {
        public GRDBContext(DbContextOptions options) : base(options)
        {
        }

        protected GRDBContext()
        {
        }
        public DbSet<Record> Records { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Jawn>().Property(jawn =>jawn.Id> Mark 4:27 Thursday
            modelBuilder.Entity<Record>().HasData(
                new Record
                {
                    ID = 1000,
                    Artist = "Noname",
                    RecordName = "Telefone",
                    DaCondition = Condition.New,
                    DaFormat = Format.Vinyl,
                    GenreType = Genre.Rap,
                    Price = 249.99M
                }
                ) ;
        } 
    }
}
