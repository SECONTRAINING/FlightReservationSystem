using DataModelLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FlightDbContext : DbContext
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

        public DbSet<FlightDetails> FlightDetails { get; set; }

        public DbSet<FlightSchedule> FlightSchedule { get; set; }
        public DbSet<FlightSeat> FlightSeat { get; set; }
        public DbSet<UserFlight> UserFlight { get; set; }


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
