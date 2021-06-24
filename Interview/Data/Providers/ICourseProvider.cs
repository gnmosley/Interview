using System.Collections.Generic;
using Data.Entities;

namespace Data.Providers
{
	/// <summary>
	///		Represents a course provider. 
	/// </summary>
	public interface ICourseProvider
	{
		/// <summary>
		///		Creates a new course. 
		/// </summary>
		/// <param name="course"> The course to create. </param>
		/// <returns> The created course. </returns>
		void Create(Course course);

		/// <summary>
		///		Gets the course object by id. 
		/// </summary>
		/// <param name="id"> The course id. </param>
		/// <returns> The <see cref="Course"/> object or null. </returns>
		Course GetById(int id);

		/// <summary>
		///		Gets a list of all courses.
		/// </summary>
		/// <returns> The list of all courses. </returns>
		IEnumerable<Course> GetAll(); 
	}
}
