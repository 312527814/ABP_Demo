using Abp.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.Entitys;
using Microsoft.EntityFrameworkCore;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore
{
    public class AbpProjectNameDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Book { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public AbpProjectNameDbContext(DbContextOptions<AbpProjectNameDbContext> options) 
            : base(options)
        {
            //Context.Configuration.LazyLoadingEnabled
            
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blogs").Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Posts").HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .IsRequired()
                    .HasForeignKey(d => d.BlogId);
            });


            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Items)
                    .IsRequired()
                    .HasForeignKey(d => d.OrderId);
                //entity.HasOne(d => d.Product).WithOne().HasForeignKey<OrderItem>(s => s.PId);
            });

           


        }
    }
}
