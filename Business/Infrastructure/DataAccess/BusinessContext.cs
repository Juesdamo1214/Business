using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class BusinessContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductHistory> ProductsHistory { get; set; }
        DbSet<Tax> Taxes { get; set; }
        DbSet<Transaction> Transactions { get; set; }
    
        public BusinessContext(DbContextOptions<BusinessContext> option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>(customer =>
            {
                customer.ToTable("Customer");
                customer.HasKey(p => p.CustomerId);
                customer.Property(p => p.CustomerName).IsRequired().HasMaxLength(150);
                customer.Property(P => P.CreateDate);
                customer.Property(P => P.Address);
                customer.Property(P => P.Email).IsRequired().HasMaxLength(200);
                customer.Property(P => P.Country).IsRequired();
                customer.Property(P => P.City).IsRequired();
                customer.Property(P => P.CellPhone).IsRequired();
            });

            modelBuilder.Entity<Order>(order =>
            {
                order.ToTable("Order");

                order.HasKey(p => p.OrderId);
                order.Property(p => p.OrderDate);
                order.Property(p => p.Subtotal);
                order.Property(p => p.TotalTax);
                order.Property(p => p.Total);

                order.HasOne(p => p.Customer).WithMany(p => p.Order).HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Product>(product =>
            {
                product.ToTable("Product");

                product.HasKey(p => p.ProductId);
                product.Property(p => p.ProductName).IsRequired().HasMaxLength(100);
                product.Property(p => p.ProductCreationDate);
                product.Property(p => p.Subtotal);
                product.Property(p => p.Price);
                product.Property(p => p.StockHistory);

                product.HasOne(p => p.Tax).WithMany(p => p.Products).HasForeignKey(p => p.TaxId);
            });

            modelBuilder.Entity<ProductHistory>(productHistory =>
            {
                productHistory.ToTable("ProductHistory");

                productHistory.HasKey(p => p.ProductHistoryId);
                productHistory.Property(p => p.PriceModificationDate);
                productHistory.Property(p => p.Subtotal);
                productHistory.Property(p => p.Tax);
                productHistory.Property(p => p.Price);
                productHistory.Property(p => p.StockHistory);

                productHistory.HasOne(p => p.Product).WithMany(p => p.ProductHistory).HasForeignKey(p => p.ProductId);
            });

            modelBuilder.Entity<Tax>(productHistory =>
            {
                productHistory.ToTable("Tax");

                productHistory.HasKey(p => p.TaxId);
                productHistory.Property(p => p.TaxName);
                productHistory.Property(p => p.TaxValue);
            });

             modelBuilder.Entity<Transaction>(productHistory =>
            {
                productHistory.ToTable("Transaction");

                productHistory.HasKey(p => p.TransactionId);
                productHistory.Property(p => p.QuantityProduct);

                productHistory.HasOne(p => p.Product).WithMany(p => p.Transaction).HasForeignKey(p => p.ProductId);
                productHistory.HasOne(p => p.Order).WithMany(p => p.Transaction).HasForeignKey(p => p.OrderId);



            });



        }
    }

    
}
