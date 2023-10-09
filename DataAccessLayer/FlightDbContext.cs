using DataModelLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class FlightDbContext:DbContext
    {
        
        public FlightDbContext(DbContextOptions options) : base(options)
        {

        }
        public FlightDbContext()
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<UserWallet> UserWallet { get; set; }
        public DbSet<UserWalletTransaction> UserWalletTransaction { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("FlightReservation"));
        }
    }
}
