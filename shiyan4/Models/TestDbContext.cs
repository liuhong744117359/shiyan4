using System;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class TestDbContext:DbContext
    {
        /*public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            
        }*/
        private string ConnectionString { get; set; }
        public TestDbContext(string connString)
        {
            ConnectionString = connString;
        }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

       
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Investors> Investors { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<CompanyEmployee> Company_Empoyees { get; set; }
        public DbSet<Investors_Project> Investor_Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEmployee>(entity =>
            {
                entity.ToTable("TB_CompanyEmployee");
                entity.HasKey("ID");
                entity.Property(c => c.ID).ValueGeneratedOnAdd();
                entity.HasOne(c => c.employee).WithMany(c => c.employeeManagements).HasForeignKey(c => c.EID);
               /* entity.HasOne(c => c.incubationCompany).WithMany(c => c.employeeManagements).HasForeignKey(c => c.ICompanyID);*/
                entity.HasOne(c => c.company).WithMany(c => c.employeeManagements).HasForeignKey(c => c.CompanyID);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("TB_Project");
                entity.HasKey("ID");
                entity.Property(c => c.ID).ValueGeneratedOnAdd();
                entity.HasOne(c => c.employee).WithMany(c => c.projects).HasForeignKey(c => c.EID);
                entity.HasOne(c => c.company).WithMany(c=>c.projects).HasForeignKey(c=>c.CompanyID);
            });

            modelBuilder.Entity<Investors_Project>(entity =>
            {
                entity.ToTable("TB_InvestorsProject");
                entity.HasKey("ID");
                entity.Property(c => c.ID).ValueGeneratedOnAdd();
                entity.HasOne(c => c.investors).WithMany(c => c.investorsProjects).HasForeignKey(c => c.IID);
                entity.HasOne(c => c.project).WithMany(c => c.investorsProjects).HasForeignKey(c => c.PID);
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("TB_Employee");
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
                 
            });
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("TB_Company");
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Investors>(entity =>
            {
                entity.ToTable("TB_Investors");
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
