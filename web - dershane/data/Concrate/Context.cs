using entity.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Concrate
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ELITEBOOK\\MSSQLSERVER2012;database=DershaneDB;integrated security=true;TrustServerCertificate=True;");
		}
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<Blog_Subscribe>? Blog_Subscribes { get; set; }
        public DbSet<Blog_Post>? Blog_Posts { get; set; }
        public DbSet<Blog_Comment>? Blog_Comments { get; set; }
        //public DbSet<Class>? Classes { get; set; }
        //public DbSet<Class_Teacher>? Class_Teachers { get; set; }
        //public DbSet<Course>? Courses { get; set; }
        //public DbSet<Grade>? Grades { get; set; }
        //public DbSet<Lesson>? Lessons { get; set; }
        //public DbSet<Program>? Programs { get; set; }
        //public DbSet<Mission>? Missions { get; set; }
        //public DbSet<Student>? Students { get; set; }
        //public DbSet<Student_Lesson>? Student_Lessons { get; set; }
        //public DbSet<Teacher>? Teachers { get; set; }
	}
}
