using CoreLayer.Damain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data.Configurations
{
    public static class TaskManagerConfiguration
    {
        public const string Task_SCHEMA = "task";

        public static void AddTaskManagerConfig(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskInformation>().ToTable("TaskInformation", Task_SCHEMA);
            modelBuilder.Entity<StepType>().ToTable("StepTypes", Task_SCHEMA);
            modelBuilder.Entity<User>().ToTable("Users", Task_SCHEMA);


            //TaskInformation
            modelBuilder.Entity<TaskInformation>().Property(p => p.Title).HasMaxLength(100);
            modelBuilder.Entity<TaskInformation>().Property(p => p.Category).HasMaxLength(1000);
            modelBuilder.Entity<TaskInformation>().Property(p => p.TaskStepId).HasColumnName("FkTaskStepId");

            //StepTypes
            modelBuilder.Entity<StepType>().Property(p => p.Title).HasMaxLength(100);

            //Users
            modelBuilder.Entity<User>().Property(p => p.Family).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(p => p.Name).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(p => p.PhonNumber).HasMaxLength(11);
            modelBuilder.Entity<User>().Property(p => p.Email).HasMaxLength(200);
            modelBuilder.Entity<User>().Property(p => p.Password).HasMaxLength(100);

        }
    }
    }
