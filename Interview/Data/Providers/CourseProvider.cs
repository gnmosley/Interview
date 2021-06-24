using System.Collections.Generic;
using System.Linq;
using Data.Common;
using Data.Entities;
using Data.Exceptions;
using Data.Validation;
using Microsoft.EntityFrameworkCore;

namespace Data.Providers
{
	/// <summary>
	///		Represents a course provider. 
	/// </summary>
	public class CourseProvider
		: ICourseProvider
	{
		private readonly UniversityContext _context;
		private readonly IValidator<Course> _validator;

		///  <summary>
		/// 		Creates a new instance of a <see cref="CourseProvider"/>. 
		///  </summary>
		///  <param name="context"> The instance of a <see cref="UniversityContext"/>. </param>
		///  <param name="validator"> The instance of a <see cref="IValidator{T}"/>. </param>
		public CourseProvider(UniversityContext context, IValidator<Course> validator)
		{
			_context = context;
			_validator = validator;
		}

		/// <summary>
		///		Creates a new student. 
		/// </summary>
		/// <param name="course"> The course object to create. </param>
		public void Create(Course course)
		{
			// Validate the course. 
			if (!_validator.IsValid(course, out var errors))
				throw new ValidationException(errors);

			// Create the student. 
			_context.Courses.Add(course);
			_context.SaveChanges();
		}

		/// <summary>
		///		Gets the course object by id. 
		/// </summary>
		/// <param name="id"> The course id. </param>
		/// <returns> The <see cref="Course"/> object or null. </returns>
		public Course GetById(int id)
		{
			return _context.Courses.Find(id); 
		}

		/// <summary>
		///		Gets a list of all courses.
		/// </summary>
		/// <returns> The list of all courses. </returns>
		public IEnumerable<Course> GetAll()
		{
			return _context.Courses
				.Include(course => course.CourseProfessors)
				.ThenInclude(p => p.Professor)
				.ToList();
		}
	}
}
