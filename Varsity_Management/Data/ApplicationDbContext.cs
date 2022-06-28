using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Varsity_Management.Models;

namespace Varsity_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Class_management> Class_Managements { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Asign> Asigns { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentAssingExam> StudentResults { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
