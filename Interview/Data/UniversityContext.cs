using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	/// <summary>
	///		Represents a database context used to manage students,
	///		courses, and professors. 
	/// </summary>
	public class UniversityContext
		: DbContext
	{
		/// <summary>
		///		Gets or sets the collection of students in the database. 
		/// </summary>
		public DbSet<Student> Students { get; set; }

		/// <summary>
		///		Gets or sets the collection of courses in the database. 
		/// </summary>
		public DbSet<Course> Courses { get; set; }

		/// <summary>
		///		Gets or sets the collection of professors in the database. 
		/// </summary>
		public DbSet<Professor> Professors { get; set; }

		/// <summary>
		///		Gets or sets the collection of student enrollments in the database.
		/// </summary>
		public DbSet<Enrollment> Enrollments { get; set; }

		/// <summary>
		///     Override this method to further configure the model that was discovered by convention from the entity types
		///     exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
		///     and re-used for subsequent instances of your derived context.
		/// </summary>
		/// <remarks>
		///     If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
		///     then this method will not be run.
		/// </remarks>
		/// <param name="modelBuilder">
		///     The builder being used to construct the model for this context. Databases (and other extensions) typically
		///     define extension methods on this object that allow you to configure aspects of the model that are specific
		///     to a given database.
		/// </param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>()
				.HasMany(enrollment => enrollment.Enrollments)
				.WithOne(enrollment => enrollment.Student);
			modelBuilder.Entity<Student>()
				.HasKey(student => student.Id);


			modelBuilder.Entity<Course>()
				.HasMany(enrollment => enrollment.Enrollments)
				.WithOne(enrollment => enrollment.Course);
			modelBuilder.Entity<Course>()
				.HasKey(key => key.Id);

			modelBuilder.Entity<Professor>()
				.HasMany(enrollment => enrollment.Enrollments)
				.WithOne(enrollment => enrollment.Professor);
			modelBuilder.Entity<Professor>()
				.HasKey(key => key.Id);

			modelBuilder.Entity<CourseProfessor>()
				.HasKey(key => new { key.CourseId, key.ProfessorId });
			modelBuilder.Entity<CourseProfessor>()
				.HasOne(course => course.Course)
				.WithMany(course => course.CourseProfessors)
				.HasForeignKey(course => course.CourseId);
			modelBuilder.Entity<CourseProfessor>()
				.HasOne(professor => professor.Professor)
				.WithMany(professor => professor.CourseProfessors)
				.HasForeignKey(professor => professor.ProfessorId);
		}

		/// <summary>
		///     <para>
		///         Override this method to configure the database (and other options) to be used for this context.
		///         This method is called for each instance of the context that is created.
		///         The base implementation does nothing.
		///     </para>
		///     <para>
		///         In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have been passed
		///         to the constructor, you can use <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
		///         the options have already been set, and skip some or all of the logic in
		///         <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />.
		///     </para>
		/// </summary>
		/// <param name="optionsBuilder">
		///     A builder used to create or modify options for this context. Databases (and other extensions)
		///     typically define extension methods on this object that allow you to configure the context.
		/// </param>
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("University"); 
		}
	}
}
