//tinfo200:[2021-03-10-<aram2020>-dykstra1] - we have created a context for our database. we have created a dbset which goes with a specific database table. we also have entities which go witha certain row in a table.
//we have properties in or previous classes that would reference these entities already. we have a estudent which will have a reference to the enrollment. and the enrollment which will reference the course. so they are already connected.
//and the school context is calling the base class of dbcontext, which are the properties i just commented on.




using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-10-<aram2020>-dykstra1]- these changes are made because the names on the tables would otherwise have been plural.
        //the developers wanted singular names on the tables so they specified singular table names.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
