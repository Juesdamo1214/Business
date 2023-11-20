using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class BusinessContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderHistory> OrdersHistory { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductGroup> ProductGroups { get; set; }
        DbSet<ProductHistory> ProductsHistory { get; set; }
        DbSet<Tax> Taxes { get; set; }
        DbSet<Transaction> Transactions { get; set; }
    
        public BusinessContext(DbContextOptions<BusinessContext> option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //List<Course> courseInit = new List<Course>();
            //courseInit.Add(new Course() { CourseId = Guid.Parse("22f973e1-f297-4884-b522-2540b44750f5"), Name = "sexto" });

            modelBuilder.Entity<Customer>(customer =>
            {
                customer.ToTable("Customers");

                course.HasKey(p => p.CourseId);

                course.Property(p => p.Name).IsRequired().HasMaxLength(50);

                //course.HasData(courseInit);

            });

            //List<Student> studentInit = new List<Student>();
            //studentInit.Add(new Student() { StudentId = Guid.Parse("22f973e1-f297-4884-b522-2540b44750f4"), CourseId = Guid.Parse("22f973e1-f297-4884-b522-2540b44750f5"), Name = "William lasso", Age = 10 });

            modelBuilder.Entity<Student>(student =>
            {
                student.ToTable("Student");

                student.HasKey(p => p.StudentId);

                student.HasOne(p => p.Course).WithMany(p => p.Student).HasForeignKey(p => p.CourseId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired();

                student.Property(p => p.Name).IsRequired().HasMaxLength(50);

                student.Property(p => p.Age).IsRequired();

                //student.HasData(studentInit);
            });

            modelBuilder.Entity<NightStudent>(student =>
            {
                student.ToTable("NightStudent");

                student.HasKey(p => p.NightStudentId);

                student.HasOne(p => p.Course).WithMany(p => p.NightStudent).HasForeignKey(p => p.CourseId)
                .OnDelete(DeleteBehavior.Cascade).IsRequired();

                student.Property(p => p.Name).IsRequired().HasMaxLength(50);

                student.Property(p => p.Age).IsRequired();

                //student.HasData(studentInit);
            });

        }
    }

    
}
