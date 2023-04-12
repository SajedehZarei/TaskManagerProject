
//using Microsoft.EntityFrameworkCore;
using CoreLayer;
using CoreLayer.Damain;
using DataLayer.Data.Configurations;
using DataLayer.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class TaskManagerDbContext : DbContext//: ApplicationDbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options, 
                    IServiceProvider _provider)
                    : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagerDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.GetProperties().Any(p => p.Name == "Id"))
                    modelBuilder.Entity(entity.Name)
                           .Property("Id").HasColumnName("Pk" + entity.ClrType.Name + "Id");

            }
            modelBuilder.AddTaskManagerConfig();

            modelBuilder.AddTaskManagerSeed();
        }

        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> option) : base(option)
        {

        }

        public virtual DbSet<TaskInformation> TaskInformation { get; set; }
        public virtual DbSet<StepType> StepTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        


    }

    public class TaskManagerDbContextFactory : IDesignTimeDbContextFactory<TaskManagerDbContext>
    {
        public TaskManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TaskManagerDbContext>();
            optionsBuilder.UseSqlServer("Server=78.157.40.4;Database=TaskManager;user id=SitesUser;password=$jan54321%$#@!cxz}{P;Max Pool Size=5000 ;Connection Timeout=180000;");

            return new TaskManagerDbContext(optionsBuilder.Options);
        }
    }  
}
