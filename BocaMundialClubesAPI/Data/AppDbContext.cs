using BocaMundialClubesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BocaMundialClubesAPI.Data;


namespace BocaMundialClubesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Venta> Ventas { get; set; }

    }
}
