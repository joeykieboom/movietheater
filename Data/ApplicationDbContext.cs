using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Threading.Tasks;
using dotnet_core_theater.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace dotnet_core_theater.Data
{
    public class ApplicationDbContext : IdentityDbContext<Models.UserModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connection = @"Server=tcp:dotnet-core-theater20190312023739dbserver.database.windows.net,1433;Initial Catalog=dotnet-core-theater20190312023739_db;Persist Security Info=False;User ID=movietheater;Password=qwerty123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                optionsBuilder.UseSqlServer(connection);
            }
        }
        public DbSet<HallModel> Halls { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<ScheduleModel> Schedules { get; set; }
        public DbSet<TheaterModel> Theaters { get; set; }
        public DbSet<TicketModel> Tickets { get; set; }
    }
}
