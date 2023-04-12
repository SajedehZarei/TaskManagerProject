using CoreLayer.Damain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data.Seed
{
    public static class TaskManagerDbSeed
    {
        public static void AddTaskManagerSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StepType>().HasData(
             new StepType()
             {
                 Id = 1,
                 Title = "New",
                 IsDeleted = false,
                 IsActive = true,
                 CreatedDate = new DateTime(2021, 05, 03)
             },
             new StepType()
             {
                 Id = 2,
                 Title = "Active",
                 IsDeleted = false,
                 IsActive = true,
                 CreatedDate = new DateTime(2022, 04, 10)
             },
             new StepType()
             {
                 Id = 3,
                 Title = "Resolved",
                 IsDeleted = false,
                 IsActive = true,
                 CreatedDate = new DateTime(2022, 04, 10)
             },
             new StepType()
             {
                 Id = 4,
                 Title = "Done",
                 IsDeleted = false,
                 IsActive = true,
                 CreatedDate = new DateTime(2022, 04, 10)
             });
         }
    }
}
