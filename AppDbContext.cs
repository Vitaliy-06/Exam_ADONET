using Exam_ADONET.Configuration;
using Exam_ADONET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ADONET
{
	public class AppDbContext : DbContext
	{
        private readonly string connStr = "Server=(LocalDB)\\MSSQLLocalDB;Database=ExamDB;Trusted_Connection=True;";

		public DbSet<Project> Projects { get; set; }
		public DbSet<Part> Parts { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<SupplierPartProject> SupplierPartProjects { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connStr);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration<SupplierPartProject>(new SpjConfiguration());
		}
	}
}
