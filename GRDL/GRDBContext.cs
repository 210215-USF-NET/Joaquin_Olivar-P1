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
        public DbSet<LocationProduct> LocationProducts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Self incrementing ID's (lol)
            modelBuilder.Entity<Cart>()
                   .Property(x => x.ID)
                   .ValueGeneratedOnAdd();
            modelBuilder.Entity<CartProduct>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<LocationProduct>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Location>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderProduct>()
                .Property(x => x.ID)
                .ValueGeneratedOnAdd();

            //Customer overrides
            modelBuilder.Entity<Customer>().
                HasMany(c => c.Carts).
                WithOne(c => c.Customer).
                OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>().
                HasMany(c => c.Orders).
                WithOne(o => o.Customer).
                OnDelete(DeleteBehavior.SetNull);
            //Cart & cartProduct overrides
            modelBuilder.Entity<CartProduct>().
                HasKey(cp => new { cp.CartID, cp.RecID });
            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Cart)
                .WithMany(c => c.CartProducts)
                .HasForeignKey(cp => cp.CartID);
            modelBuilder.Entity<CartProduct>()
                .HasOne(cp => cp.Record)
                .WithMany(r => r.CartProducts)
                .HasForeignKey(cp => cp.RecID);
            //Location overrides
            modelBuilder.Entity<LocationProduct>()
                .HasKey(lp => new { lp.LocID, lp.RecID });
            modelBuilder.Entity<LocationProduct>()
                .HasOne(lp => lp.Location)
                .WithMany(l => l.LocationProducts)
                .HasForeignKey(lp => lp.LocID);
            modelBuilder.Entity<LocationProduct>()
                .HasOne(lp => lp.Record)
                .WithMany(r => r.LocationProducts)
                .HasForeignKey(lp => lp.LocID);
            //Order ovverrides
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrdID, op.RecID });
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrdID);
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Record)
                .WithMany(r => r.OrderProducts)
                .HasForeignKey(op=>op.RecID);

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
