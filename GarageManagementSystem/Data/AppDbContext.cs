using GarageManagementSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace GarageManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }


        public DbSet<Car> Cars {  get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
}
