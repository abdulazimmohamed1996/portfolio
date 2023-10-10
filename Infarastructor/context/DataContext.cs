using Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infarastructor.context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var constring = configuration.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(constring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortofolioItem>().Property(x => x.Id).HasDefaultValueSql ("NEWID()");
            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id=Guid.NewGuid(),
                    Avatar="Zima.jpg",
                    FullName="Abdulazim Mohamed",
                    Profil="FullStack DotNetDevloper"
                }

                );
        }
        
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortofolioItem> PortofolioItems { get; set; }
        public DbSet<Address> addresses { get; set; }
    }
}
