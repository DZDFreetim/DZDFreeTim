using DZDFreeTim.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Data
{
    public class AppDbContext : DbContext
    {
        // Tum claslar buraya eklenecek 
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

       

        //DB adını DZDFreeTim verdim, solution adı ile aynı olsun 
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=DZDFreeTimDb; Integrated Security=SSPI;";

            builder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
