using DZDFreeTim.Data.Entity;
using DZDFreeTim.Data.Seeders;
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
        
        // Tum claslar buraya eklenecek Model sınıfını temsil ediyor
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<DzdStatus> DzdStatuses { get; set; }
        public DbSet<IntertechTeam> IntertechTeams { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueStatus> IssueStatuses { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<JiraStatus> JiraStatuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Resolution> Resolutions { get; set; }
        public DbSet<Team> Teams { get; set; }


        // DB Bağlantı Metni
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
          //  string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=DZDFreeTimDb; Integrated Security=SSPI;";
            string connectionString  = "Data Source=45.158.14.184 ;Initial Catalog=DZDFreeTeam; User ID=sa;password='DzdTech2022++';";


            builder.UseSqlServer(connectionString);
        }


        // 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //model seeder , 14 class için tek tek yazılacaak
            EmployeeSeeder.SeedData(modelBuilder);
            BankSeeder.SeedData(modelBuilder);
            DepartmentSeeder.SeedData(modelBuilder);
            DzdStatusSeeder.SeedData(modelBuilder);
            IntertechTeamSeeder.SeedData(modelBuilder);
            IssueSeeder.SeedData(modelBuilder);
            IssueStatusSeeder.SeedData(modelBuilder);
            IssueTypeSeeder.SeedData(modelBuilder);
            PrioritySeeder.SeedData(modelBuilder);
            ProjectSeeder.SeedData(modelBuilder);
            ReporterSeeder.SeedData(modelBuilder);
            ResolutionSeeder.SeedData(modelBuilder);
            TeamSeeder.SeedData(modelBuilder);
        }
    }
}
