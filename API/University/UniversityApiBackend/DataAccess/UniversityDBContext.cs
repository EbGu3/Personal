﻿using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }

        //  TODO: Add DbSets (Tablas de la base de datos)
        public DbSet<User>? User { get; set; }
        public DbSet<Course>? Course { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapters>? Chapters { get; set; }
    }
}
