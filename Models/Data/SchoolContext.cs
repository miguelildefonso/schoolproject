using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace SchoolProject.Models.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            :base(options){ }       
        public DbSet<Admin_User> admin_user {get; set;}
        public DbSet<Programs> program {get; set;}
        public DbSet<Professor> professor {get; set;}
        public DbSet<Student> student {get; set;}
        public DbSet<Subject> subject {get; set;}
    }
}