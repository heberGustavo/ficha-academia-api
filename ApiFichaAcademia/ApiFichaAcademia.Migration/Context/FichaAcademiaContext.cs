﻿using ApiFichaAcademia.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Migrations.Context
{
	public class FichaAcademiaContext : DbContext
	{
        public FichaAcademiaContext(DbContextOptions<FichaAcademiaContext> option) : base(option) { }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<LevelExercise> LevelExercise { get; set; }
    }
}
